using System.Collections.Generic;
using System.Linq;
using PostMortem.Core.Results;
using Serilog;

namespace PostMortem.Core.Compare
{
    public class Comparer
    {
        public CompareResult CompareResults(AnalysisResult left, AnalysisResult right)
        {
            Log.Verbose("Starting comparison");

            // Ensure that "left" is the older dump
            var ordered = new[] { left, right }.OrderBy(result => result.GeneralInfo.DumpFileCreationTime).ToList();
            var olderDump = ordered.ElementAt(0);
            var newerDump = ordered.ElementAt(1);

            // Look for new Exceptions

            // Check for changes in objects count

            var compareResult = new CompareResult
            {
                GeneralInfos = new GeneralInfos
                {
                    OlderDump = olderDump.GeneralInfo,
                    NewerDump = newerDump.GeneralInfo,
                },
                MatchingThreads = GetMatchingThreads(olderDump, newerDump)
            };

            return compareResult;
        }

        private static IEnumerable<MatchingThread> GetMatchingThreads(AnalysisResult olderDump, AnalysisResult newerDump)
        {
            Log.Verbose("Determine matching threads");

            var matchingThreads = new List<MatchingThread>();
            foreach (var threadFromOlder in olderDump.Threads)
            {
                var threadFromNewer = newerDump.Threads.FirstOrDefault(t => t.OsThreadId == threadFromOlder.OsThreadId);
                if (threadFromNewer == null) continue;

                var matchingFrames = new List<StackFrameInfo>();
                var isFullTraceMatch = threadFromOlder.StackFrameInfos.Any();
                foreach (var frameInfo in threadFromOlder.StackFrameInfos)
                {
                    var matchingFrame = threadFromNewer.StackFrameInfos.FirstOrDefault(info =>
                        info.InstructionPointer == frameInfo.InstructionPointer);

                    if (matchingFrame == null)
                    {
                        isFullTraceMatch = false;
                        continue;
                    }

                    matchingFrames.Add(matchingFrame);
                }

                var matchingThread = new MatchingThread
                {
                    ThreadFromOlder = threadFromOlder,
                    ThreadFromNewer = threadFromNewer,
                    MatchingFrames = matchingFrames,
                    IsFullTraceMatch = isFullTraceMatch
                };
                matchingThreads.Add(matchingThread);
            }

            return matchingThreads;
        }
    }
}
