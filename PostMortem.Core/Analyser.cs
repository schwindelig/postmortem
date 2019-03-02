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
        }

        private void DumpGcHandles(ClrRuntime runtime)
        {
            foreach (var handle in runtime.EnumerateHandles())
            {
                var objectType = runtime.Heap.GetObjectType(handle.Object).Name;
                Log.Information("{address,12:X} {object,12:X} {type,12} {objectType}", handle.Address, handle.Object, handle.Type, objectType);
            }
        }

        private static void DumpMemoryRegions(ClrRuntime runtime)
        {
            Log.Information("Memory regions:");
            foreach (var region in (from r in runtime.EnumerateMemoryRegions()
                where r.Type != ClrMemoryRegionType.ReservedGCSegment
                group r by r.Type into g
                let total = g.Sum(p => (uint)p.Size)
                orderby total descending
                select new
                {
                    TotalSize = total,
                    Count = g.Count(),
                    Type = g.Key
                }))
            {
                Log.Information("{count,6:n0} {totalSize,12:n0} {type}", region.Count, region.TotalSize, region.Type);
            }
        }

        private static void DumpAppDomains(ClrRuntime runtime)
        {
            Log.Information("App domain(s): {domains}", runtime.AppDomains.Count);
            foreach (var appDomain in runtime.AppDomains)
            {
                Log.Information("App Domain {id}: {name}", appDomain.Id, appDomain.Name);
                Log.Information("Loaded modules (App Domain {id}): {modules}", appDomain.Id, appDomain.Modules);
            }
        }

        private static void DumpThreads(ClrRuntime runtime)
        {
            Log.Information("Threads: {threadCount} ({aliveThreadCount} alive)", runtime.Threads.Count, runtime.Threads.Count(thread => thread.IsAlive));
            foreach (var thread in runtime.Threads)
            {
                var exception = thread.CurrentException;
                if (exception != null)
                {
                    Log.Information("Exception in thread {threadId:X}: {exception}", thread.OSThreadId, exception);
                }

                if(!thread.IsAlive) continue;

                Log.Information("Thread {threadId:X} stack trace:", thread.OSThreadId);
                foreach (var frame in thread.StackTrace)
                {
                    Log.Information("{stackPointer,12:X} {instructionPointer,12:X} {frame}", frame.StackPointer, frame.InstructionPointer, frame);
                }
            }
        }

        private static void DumpRuntimeInfo(ClrRuntime runtime)
        {
            Log.Information("Pointer Size: {pointerSize} bytes", runtime.PointerSize);
            Log.Information("Server Garbage Collector: {serverGc}", runtime.ServerGC);
            Log.Information("Heap Count: {heapCount}", runtime.HeapCount);
        }

        private static void ValidateOptions(AnalyserOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.Path)) throw new InvalidOptionsException("No path defined");

            if (!File.Exists(options.Path)) throw new InvalidOptionsException($"Dump File does not exist: {options.Path}");

            Log.Verbose("Analyser Options are valid: {@options}", options);
        }

        private ClrRuntime LoadDump(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));

            this._dataTarget = DataTarget.LoadCrashDump(path);
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
