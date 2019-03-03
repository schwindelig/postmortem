using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Diagnostics.Runtime;
using PostMortem.Core.Exceptions;
using PostMortem.Core.Results;
using Serilog;

namespace PostMortem.Core.Analyse
{
    public class Analyser : IDisposable
    {
        private DataTarget _dataTarget;

        public AnalysisResult RunAnalysis(AnalyserOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            try
            {
                ValidateOptions(options);
            }
            catch (InvalidOptionsException exception)
            {
                Log.Error(exception, "Provided analyser options are invalid");
                throw;
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Error while validating options");
                throw;
            }

            ClrRuntime runtime;
            try
            {
                runtime = LoadDump(options.Path);
                Log.Verbose("Loaded crash dump at {path}", options.Path);
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Failed to load dump");
                throw;
            }

            var analysisResult = new AnalysisResult
            {
                RuntimeInfo = GetRuntimeInfo(runtime),
                AppDomains = GetAppDomains(runtime),
                Threads = GetThreads(runtime),
                MemoryRegions = GetMemoryRegions(runtime),
                HeapSegments = GetHeapSegments(runtime),
                HeapBalance = GetHeapBalance(runtime),
                Objects = GetObjects(runtime)
            };

            Log.Verbose("Finished analysis");

            return analysisResult;
        }

        private static IEnumerable<ObjectInfo> GetObjects(ClrRuntime runtime)
        {
            Log.Verbose("Getting objects");

            if (!runtime.Heap.CanWalkHeap)
            {
                throw new CannotWalkHeapException("Unable to walk Heap. The dump might have been taken during a GC");
            }

            var objectAddresses = runtime.Heap.EnumerateObjectAddresses();
            var objectInfos = objectAddresses
                .Select(objectAddress =>
                {
                    var type = runtime.Heap.GetObjectType(objectAddress);
                    if (type == null)
                        return
                            null; //throw new HeapCorruptedException($"Failed to get type of object at address {objectAddress:X}. Heap might be corrupted");

                    var size = type.GetSize(objectAddress);

                    return new ObjectInfo
                    {
                        TypeName = type.Name,
                        Size = size
                    };
                })
                .Where(arg => arg != null)
                .ToList();

            return objectInfos;
        }

        private static IEnumerable<HeapBalanceInfo> GetHeapBalance(ClrRuntime runtime)
        {
            Log.Verbose("Getting Heap Balance");

            var heapBalanceInfos = runtime.Heap.Segments.GroupBy(seg => seg.ProcessorAffinity)
                .OrderBy(group => group.Key)
                .Select(group => new HeapBalanceInfo
                {
                    Heap = group.Key,
                    Size = group.Sum(p => (uint) p.Length)
                }).ToList();

            return heapBalanceInfos;
        }

        private static IEnumerable<HeapSegmentInfo> GetHeapSegments(ClrRuntime runtime)
        {
            Log.Verbose("Getting Heap Segments");

            var heapSegmentInfos = new List<HeapSegmentInfo>();
            foreach (var segment in runtime.Heap.Segments)
            {
                string type;
                if (segment.IsEphemeral)
                    type = "Ephemeral";
                else if (segment.IsLarge)
                    type = "Large";
                else
                    type = "Gen2";

                heapSegmentInfos.Add(new HeapSegmentInfo
                {
                    Start = segment.Start,
                    CommittedEnd = segment.End,
                    ReservedEnd = segment.ReservedEnd,
                    Heap = segment.ProcessorAffinity,
                    Type = type
                });
            }

            return heapSegmentInfos;
        }

        private void DumpGcHandles(ClrRuntime runtime)
        {
            Log.Information("GC Handles:");
            foreach (var handle in runtime.EnumerateHandles())
            {
                var objectType = runtime.Heap.GetObjectType(handle.Object).Name;
                Log.Information("{address,12:X} {object,12:X} {type,12} {objectType}", handle.Address, handle.Object,
                    handle.Type, objectType);
            }
        }

        private static IEnumerable<MemoryRegionInfo> GetMemoryRegions(ClrRuntime runtime)
        {
            Log.Verbose("Getting Memory Regions");

            var memoryRegionInfos = runtime.EnumerateMemoryRegions()
                .Where(r => r.Type != ClrMemoryRegionType.ReservedGCSegment)
                .GroupBy(r => r.Type)
                .Select(group => new
                {
                    g = group,
                    total = group.Sum(p => (uint) p.Size)
                })
                .OrderByDescending(t => t.total)
                .Select(t => new MemoryRegionInfo
                {
                    TotalSize = t.total,
                    Count = t.g.Count(),
                    Type = t.g.Key
                })
                .ToList();

            return memoryRegionInfos;
        }

        private static IEnumerable<AppDomainInfo> GetAppDomains(ClrRuntime runtime)
        {
            Log.Verbose("Getting App Domains");

            return runtime.AppDomains.Select(appDomain => new AppDomainInfo
            {
                Name = appDomain.Name,
                Modules = appDomain.Modules.Select(m => m.Name)
            }).ToList();
        }

        private static IEnumerable<ThreadInfo> GetThreads(ClrRuntime runtime)
        {
            Log.Verbose("Getting Threads");

            var threadInfos = new List<ThreadInfo>();
            foreach (var thread in runtime.Threads)
            {
                ExceptionInfo exceptionInfo = null;
                var exception = thread.CurrentException;
                if (exception != null)
                {
                    exceptionInfo = new ExceptionInfo
                    {
                        Message = exception.Message,
                        HResult = exception.HResult
                    };
                }

                var stackFrameInfos = new List<StackFrameInfo>();
                if (thread.IsAlive)
                {
                    stackFrameInfos.AddRange(thread.StackTrace.Select(frame =>
                        new StackFrameInfo
                        {
                            StackPointer = frame.StackPointer,
                            InstructionPointer = frame.InstructionPointer,
                            DisplayString = frame.DisplayString
                        }));
                }

                threadInfos.Add(new ThreadInfo
                {
                    IsAlive = thread.IsAlive,
                    OsThreadId = thread.OSThreadId,
                    ExceptionInfo = exceptionInfo,
                    StackFrameInfos = stackFrameInfos
                });
            }

            return threadInfos;
        }

        private static void DumpStack(ClrRuntime runtime, ClrThread thread)
        {
            // We'll need heap data to find objects on the stack.
            var heap = runtime.Heap;

            // Walk each pointer aligned address on the stack.  Note that StackBase/StackLimit
            // is exactly what they are in the TEB.  This means StackBase > StackLimit on AMD64.
            var start = thread.StackBase;
            var stop = thread.StackLimit;

            // We'll walk these in pointer order.
            if (start > stop)
            {
                var tmp = start;
                start = stop;
                stop = tmp;
            }

            Log.Information("Stack objects:");

            // Walk each pointer aligned address.  Ptr is a stack address.
            for (var ptr = start; ptr <= stop; ptr += (ulong) runtime.PointerSize)
            {
                // Read the value of this pointer.  If we fail to read the memory, break.  The
                // stack region should be in the crash dump.
                if (!runtime.ReadPointer(ptr, out var obj))
                    break;

                // We check to see if this address is a valid object by simply calling
                // GetObjectType.  If that returns null, it's not an object.
                var type = heap.GetObjectType(obj);
                if (type == null)
                    continue;

                // Don't print out free objects as there tends to be a lot of them on
                // the stack.
                if (type.IsFree)
                    continue;

                Log.Information("{pointer,16:X} {object,16:X} {typeName}", ptr, obj, type.Name);

                try
                {
                    WriteFields(obj, type);
                }
                catch (Exception e)
                {
                    Log.Error("Failed to write values");
                }
            }
        }

        private static RuntimeInfo GetRuntimeInfo(ClrRuntime runtime)
        {
            Log.Verbose("Getting Runtime Info");
            return new RuntimeInfo
            {
                PointerSize = runtime.PointerSize,
                ServerGarbageCollector = runtime.ServerGC,
                HeapCount = runtime.HeapCount
            };
        }

        private static void ValidateOptions(AnalyserOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.Path)) throw new InvalidOptionsException("No path defined");

            if (!File.Exists(options.Path))
                throw new InvalidOptionsException($"Dump File does not exist: {options.Path}");

            Log.Verbose("Analyser Options are valid: {@options}", options);
        }

        public static void WriteFields(ulong obj, ClrType type)
        {
            WriteFieldsWorker(obj, type, null, 0, false);
        }

        private static void WriteFieldsWorker(ulong obj, ClrType type, string baseName, int offset, bool inner)
        {
            // Keep track of nested fields.
            if (baseName == null)
                baseName = "";
            else
                baseName += ".";

            foreach (var field in type.Fields)
            {
                var addr = field.GetAddress(obj, inner);

                string output;
                if (field.HasSimpleValue)
                    output = field.GetValue(obj, inner).ToString();
                else
                    output = addr.ToString("X");
                Log.Information("  +{offset,2:X2} {typeName} {baseName}{fieldName} = {output}", field.Offset + offset,
                    field.Type.Name, baseName,
                    field.Name, output);

                // Recurse for structs.
                if (field.ElementType == ClrElementType.Struct)
                    WriteFieldsWorker(addr, field.Type, baseName + field.Name, offset + field.Offset, true);
            }
        }

        private ClrRuntime LoadDump(string path)
        {
            Log.Verbose("Loading Dump");

            this._dataTarget?.Dispose();
            this._dataTarget = null;

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));

            _dataTarget = DataTarget.LoadCrashDump(path);
            Log.Verbose("CLR Versions found in dump: {versions}", _dataTarget.ClrVersions);

            var version = _dataTarget.ClrVersions.FirstOrDefault();
            if (version == null) throw new LoadDumpException("No CLR version found in dump");

            Log.Verbose("Using CLR Version {version} for analysis", version);
            return version.CreateRuntime();
        }

        public void Dispose()
        {
            _dataTarget?.Dispose();
        }
    }
}