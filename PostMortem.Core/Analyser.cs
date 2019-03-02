using System;
using System.IO;
using System.Linq;
using Microsoft.Diagnostics.Runtime;
using PostMortem.Core.Exceptions;
using Serilog;

namespace PostMortem.Core
{
    public class Analyser : IDisposable
    {
        private DataTarget _dataTarget;

        public void RunAnalysis(AnalyserOptions options)
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

            DumpRuntimeInfo(runtime);
            DumpAppDomains(runtime);
            DumpThreads(runtime);
            DumpMemoryRegions(runtime);
            DumpHeapSegments(runtime);
            DumpHeapBalance(runtime);
            DumpTopObjects(runtime);
        }

        private static void DumpTopObjects(ClrRuntime runtime)
        {
            Log.Information("Top Objects:");
            if (!runtime.Heap.CanWalkHeap)
                throw new CannotWalkHeapException("Unable to walk Heap. The dump might have been taken during a GC");

            var objectAddresses = runtime.Heap.EnumerateObjectAddresses();
            var t = objectAddresses
                .Select(objectAddress =>
                {
                    var type = runtime.Heap.GetObjectType(objectAddress);
                    if (type == null)
                        return
                            null; //throw new HeapCorruptedException($"Failed to get type of object at address {objectAddress:X}. Heap might be corrupted");

                    var size = type.GetSize(objectAddress);

                    return new
                    {
                        Type = type,
                        Size = size
                    };
                })
                .Where(arg => arg != null)
                .GroupBy(arg => arg.Type, (type, enumerable) =>
                {
                    var enumerable1 = enumerable.ToList();
                    return new
                    {
                        Type = type,
                        enumerable1.Count,
                        TotalSize = enumerable1.Select(arg => arg.Size).Aggregate(0UL, (a, b) => a + b)
                    };
                })
                .OrderByDescending(arg => arg.TotalSize)
                .Take(100);

            foreach (var group in t)
                Log.Information("{type}: {count} instances - {totalSize:n0} bytes", group.Type, group.Count,
                    group.TotalSize);
        }

        private static void DumpHeapBalance(ClrRuntime runtime)
        {
            Log.Information("Heap Balance:");
            foreach (var item in from seg in runtime.Heap.Segments
                group seg by seg.ProcessorAffinity
                into g
                orderby g.Key
                select new
                {
                    Heap = g.Key,
                    Size = g.Sum(p => (uint) p.Length)
                })
                Log.Information("Heap {heap,2}: {size:n0} bytes", item.Heap, item.Size);
        }

        private static void DumpHeapSegments(ClrRuntime runtime)
        {
            Log.Information("Heap Segments:");
            Log.Information("{start,12} {end,12} {committedEnd,12} {reservedEnd,12} {heap,4} {type}", "Start", "End",
                "CommittedEnd", "ReservedEnd", "Heap", "Type");
            foreach (var segment in runtime.Heap.Segments)
            {
                string type;
                if (segment.IsEphemeral)
                    type = "Ephemeral";
                else if (segment.IsLarge)
                    type = "Large";
                else
                    type = "Gen2";

                Log.Information(
                    "{start,12:X} {end,12:X} {committedEnd,12:X} {reservedEnd,12:X} {processorAffinity,4} {type}",
                    segment.Start, segment.End, segment.CommittedEnd, segment.ReservedEnd, segment.ProcessorAffinity,
                    type);
            }
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

        private static void DumpMemoryRegions(ClrRuntime runtime)
        {
            Log.Information("Memory regions:");
            foreach (var region in from r in runtime.EnumerateMemoryRegions()
                where r.Type != ClrMemoryRegionType.ReservedGCSegment
                group r by r.Type
                into g
                let total = g.Sum(p => (uint) p.Size)
                orderby total descending
                select new
                {
                    TotalSize = total,
                    Count = g.Count(),
                    Type = g.Key
                })
                Log.Information("{count,6:n0} {totalSize,12:n0} {type}", region.Count, region.TotalSize, region.Type);
        }

        private static void DumpAppDomains(ClrRuntime runtime)
        {
            Log.Information("App Domains:");
            Log.Information("App Domain(s): {domains}", runtime.AppDomains.Count);
            foreach (var appDomain in runtime.AppDomains)
            {
                Log.Information("App Domain {id}: {name}", appDomain.Id, appDomain.Name);
                Log.Information("Loaded modules (App Domain {id}): {modules}", appDomain.Id, appDomain.Modules);
            }
        }

        private static void DumpThreads(ClrRuntime runtime)
        {
            Log.Information("Threads:");
            Log.Information("Threads: {threadCount} ({aliveThreadCount} alive)", runtime.Threads.Count,
                runtime.Threads.Count(thread => thread.IsAlive));
            foreach (var thread in runtime.Threads)
            {
                var exception = thread.CurrentException;
                if (exception != null)
                    Log.Information("Exception in thread {threadId:X}: {exception}", thread.OSThreadId, exception);

                if (!thread.IsAlive) continue;

                Log.Information("Thread {threadId:X} stack trace:", thread.OSThreadId);
                foreach (var frame in thread.StackTrace)
                    Log.Information("{stackPointer,12:X} {instructionPointer,12:X} {frame}", frame.StackPointer,
                        frame.InstructionPointer, frame);

                //DumpStack(runtime, thread); // This will print every value
            }
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
            for (var ptr = start; ptr <= stop; ptr += (ulong)runtime.PointerSize)
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

        private static void DumpRuntimeInfo(ClrRuntime runtime)
        {
            Log.Information("Runtime information:");
            Log.Information("Pointer Size: {pointerSize} bytes", runtime.PointerSize);
            Log.Information("Server Garbage Collector: {serverGc}", runtime.ServerGC);
            Log.Information("Heap Count: {heapCount}", runtime.HeapCount);
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
                    Log.Information("  +{offset,2:X2} {typeName} {baseName}{fieldName} = {output}", field.Offset + offset, field.Type.Name, baseName,
                        field.Name, output);

                // Recurse for structs.
                if (field.ElementType == ClrElementType.Struct)
                    WriteFieldsWorker(addr, field.Type, baseName + field.Name, offset + field.Offset, true);
            }
        }

        private ClrRuntime LoadDump(string path)
        {
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