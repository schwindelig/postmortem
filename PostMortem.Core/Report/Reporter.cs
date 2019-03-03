using System;
using System.IO;
using System.Linq;
using PostMortem.Core.Analyse;
using PostMortem.Core.Results;
using PostMortem.Markdown;

namespace PostMortem.Core.Report
{
    public class Reporter
    {
        public void GenerateReport(AnalysisResult result, string outputDirectory)
        {
            var document = new MarkdownDocument();

            // Title
            document.WriteHeader1($"PostMortem Report - {DateTime.Now:F}");

            // Runtime Info
            document.WriteHeader2("Runtime Info");
            document.WriteTable<RuntimeInfo>(
                result.RuntimeInfo, new []
                {
                    "Pointer Size",
                    "Heap Count",
                    "Server Garbage Collector"
                }, 
                info => info.PointerSize.ToString(),
                info => info.HeapCount.ToString(),
                info => info.ServerGarbageCollector.ToString());

            // App Domains
            document.WriteHeader2("App Domains");
            foreach (var appDomain in result.AppDomains)
            {
                document.WriteHeader3(appDomain.Name);
                document.WriteLine("Loaded Modules:");
                document.WriteOrderedList(appDomain.Modules.OrderBy(s => s));
            }

            // More derp

            // Export the shizzle
            var path = Path.Combine(outputDirectory, $"{Guid.NewGuid():D}-report.md");
            new Exporter().ExportFile(document.GetString(), path);
        }
    }
}
