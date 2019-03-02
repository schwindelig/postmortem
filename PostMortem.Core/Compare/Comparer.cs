using PostMortem.Core.Results;
using Serilog;

namespace PostMortem.Core.Compare
{
    public class Comparer
    {
        public void CompareResults(AnalysisResult left, AnalysisResult right)
        {
            Log.Verbose("Starting comparison");
        }
    }
}
