using System.Collections.Generic;

namespace PostMortem.Core.Results
{
    public class CompareResult
    {
        public GeneralInfos GeneralInfos { get; set; }

        public IEnumerable<MatchingThread> MatchingThreads { get; set; }

        public IEnumerable<ObjectCountDiffInfo> ObjectDiffs { get; set; }
    }

    public class ObjectCountDiffInfo
    {
        public ObjectInfo ObjectInfo { get; set; }

        public int? Difference { get; set; }
    }

    public class GeneralInfos
    {
        public GeneralInfo OlderDump { get; set; }

        public GeneralInfo NewerDump { get; set; }
    }

    public class MatchingThread
    {
        public ThreadInfo ThreadFromOlder { get; set; }

        public ThreadInfo ThreadFromNewer { get; set; }

        public IEnumerable<StackFrameInfo> MatchingFrames { get; set; }

        public bool IsFullTraceMatch { get; set; }
    }
}
