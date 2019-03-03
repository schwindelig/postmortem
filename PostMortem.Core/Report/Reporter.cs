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
            document.WriteTable(
                result.RuntimeInfo, new[]
                {
                    "Pointer Size",
                    "Heap Count",
                    "Server Garbage Collector"
                },
                info => info.PointerSize.ToString(),
                info => info.HeapCount.ToString(),
                info => info.ServerGarbageCollector.ToString());

            // Memory Regions
            document.WriteHeader2("Memory Regions");
            document.WriteTable(
                result.MemoryRegions,
                new[]
                {
                    "Total Size",
                    "Count",
                    "Type"
                },
                info => $"{info.TotalSize,6:n0}",
                info => $"{info.Count,12:n0}",
                info => info.Type.ToString().MakeInlineCode());

            // Heap Segments
            document.WriteHeader2("Heap Segments");
            document.WriteTable(
                result.HeapSegments,
                new[]
                {
                    "Start",
                    "End",
                    "Committed End",
                    "Reserved End",
                    "Heap",
                    "Type"
                },
                info => $"{info.Start.ToString("x12").MakeInlineCode()}",
                info => $"{info.End.ToString("x12").MakeInlineCode()}",
                info => $"{info.CommittedEnd.ToString("x12").MakeInlineCode()}",
                info => $"{info.ReservedEnd.ToString("x12").MakeInlineCode()}",
                info => $"{info.Heap,4}",
                info => $"{info.Type.MakeInlineCode()}"
            );

            // Heap Balance
            document.WriteHeader2("Heap Balance");
            document.WriteTable(
                result.HeapBalance,
                new[]
                {
                    "Heap",
                    "Size in Bytes"
                },
                info => $"{info.Heap,2}",
                info => $"{info.Size:n0}"
            );

            // App Domains
            document.WriteHeader2("App Domains");
            foreach (var appDomain in result.AppDomains)
            {
                document.WriteHeader3(appDomain.Name);
                document.WriteLine("Loaded Modules:");
                document.WriteOrderedList(appDomain.Modules.Where(s => !string.IsNullOrWhiteSpace(s)).OrderBy(s => s));
            }

            // Threads
            document.WriteHeader2("Threads");
            var totalThreads = result.Threads.Count();
            var aliveThreads = result.Threads.Count(t => t.IsAlive);
            document.WriteLine($"Total Threads: {totalThreads} (Alive: {aliveThreads})");
            foreach (var threadInfo in result.Threads.Where(t => t.IsAlive))
            {
                document.WriteHeader3($"{threadInfo.OsThreadId,12:X}");
                if (threadInfo.ExceptionInfo != null)
                {
                    document.WriteLine("Thread contains an exception");
                    document.WriteHeader4("Exception info");
                    document.WriteLine($"Message: {threadInfo.ExceptionInfo.Message}");
                    document.WriteLine($"HRESULT: {threadInfo.ExceptionInfo.HResult}");
                }

                document.WriteHeader4("Stack Trace");
                document.WriteTable(
                    threadInfo.StackFrameInfos,
                    new[]
                    {
                        "Stack Pointer",
                        "Instruction Pointer",
                        "Display String"
                    },
                    info => $"{info.StackPointer,12:X}".MakeInlineCode(),
                    info => $"{info.InstructionPointer,12:X}".MakeInlineCode(),
                    info => info.DisplayString.MakeInlineCode()
                );
            }

            // Objects
            var topObjects = result.Objects
                .GroupBy(o => o.TypeName)
                .Select(infos => new
                {
                    Type = infos.Key,
                    Count = infos.Count(),
                    TotalSize = infos.Sum(info => (uint)info.Size)
                })
                .OrderByDescending(arg => arg.TotalSize)
                .Take(100);

            document.WriteHeader2("Top Objects");
            document.WriteTable(
                topObjects,
                new[]
                {
                    "Type",
                    "Count",
                    "Total Size in bytes"
                },
                arg => arg.Type.MakeInlineCode(),
                arg => arg.Count.ToString(),
                arg => arg.TotalSize.ToString()
            );

            // Export the shizzle
            var path = Path.Combine(outputDirectory, $"{Guid.NewGuid():D}-report.md");
            new Exporter().ExportFile(document.GetString(), path);
        }
    }
}