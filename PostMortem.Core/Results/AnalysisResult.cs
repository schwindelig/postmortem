using System.Collections.Generic;
using Microsoft.Diagnostics.Runtime;

namespace PostMortem.Core.Results
{
    public class AnalysisResult
    {
        public RuntimeInfo RuntimeInfo { get; set; }

        public IEnumerable<AppDomainInfo> AppDomains { get; set; }

        public IEnumerable<ThreadInfo> Threads { get; set; }

        public IEnumerable<MemoryRegionInfo> MemoryRegions { get; set; }

        public IEnumerable<HeapSegmentInfo> HeapSegments { get; set; }

        public IEnumerable<HeapBalanceInfo> HeapBalance { get; set; }

        public IEnumerable<ObjectInfo> Objects { get; set; }
    }

    public class ObjectInfo
    {
        public ulong Size { get; set; }

        public string TypeName { get; set; }
    }

    public class HeapBalanceInfo
    {
        public int Heap { get; set; }

        public long Size { get; set; }
    }

    public class HeapSegmentInfo
    {
        public ulong Start { get; set; }

        public ulong CommittedEnd { get; set; }

        public ulong ReservedEnd { get; set; }

        public int Heap { get; set; }

        public string Type { get; set; }
    }

    public class MemoryRegionInfo
    {
        public long TotalSize { get; set; }

        public int Count { get; set; }

        public ClrMemoryRegionType Type { get; set; }
    }

    public class StackFrameInfo
    {
        public ulong StackPointer { get; set; }

        public ulong InstructionPointer { get; set; }

        public string DisplayString { get; set; }
    }

    public class ExceptionInfo
    {
        public string Message { get; set; }

        public int HResult { get; set; }
    }

    public class ThreadInfo
    {
        public bool IsAlive { get; set; }

        public ExceptionInfo ExceptionInfo { get; set; }

        public uint OsThreadId { get; set; }

        public List<StackFrameInfo> StackFrameInfos { get; set; }
    }

    public class AppDomainInfo
    {
        public string Name { get; set; }

        public IEnumerable<string> Modules { get; set; }
    }

    public class RuntimeInfo
    {
        public int PointerSize { get; set; }

        public bool ServerGarbageCollector { get; set; }

        public int HeapCount { get; set; }
    }
}