using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PostMortem.Core.Export;
using PostMortem.Core.Results;
using PostMortem.Markdown;
using Serilog;

namespace PostMortem.Core.Report
{
    public class Reporter
    {
        public void GenerateAnalysisReport(AnalysisResult result, string outputDirectory)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));
            if (string.IsNullOrWhiteSpace(outputDirectory))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(outputDirectory));

            Log.Verbose("Generating analysis report");

            var document = new MarkdownDocument();

            // Title
            document.WriteHeader1($"PostMortem Analysis Report for {result.GeneralInfo.DumpFileName.MakeInlineCode()}");
            document.WriteParagraph($"Report generated: {DateTime.Now:F}");

            // General Info
            document.WriteHeader2("General Information");
            document.WriteParagraph($"Dump File Creation Time: {result.GeneralInfo.DumpFileCreationTime:F}");
            document.WriteParagraph($"Dump File Path: {result.GeneralInfo.DumpFilePath.MakeInlineCode()}");

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
                document.WriteParagraph("Loaded Modules:");
                document.WriteOrderedList(appDomain.Modules.Where(s => !string.IsNullOrWhiteSpace(s)).OrderBy(s => s));
            }

            // Threads
            document.WriteHeader2("Threads");
            var totalThreads = result.Threads.Count();
            var aliveThreads = result.Threads.Count(t => t.IsAlive);
            document.WriteParagraph($"Total Threads: {totalThreads} (Alive: {aliveThreads})");
            foreach (var threadInfo in result.Threads.Where(t => t.IsAlive))
            {
                var prefix = threadInfo.ExceptionInfo != null ? $"{MarkdownEmojis.Fire} " : null;
                document.WriteHeader3($"{prefix}Thread {threadInfo.OsThreadId.ToString("x12").MakeInlineCode()}");
                if (threadInfo.ExceptionInfo != null)
                {
                    document.WriteParagraph("Thread contains an exception".MakeMarked());

                    document.WriteHeader4("Exception info");
                    document.WriteParagraph($"Type: {threadInfo.ExceptionInfo.Type}");
                    document.WriteParagraph($"Message: {threadInfo.ExceptionInfo.Message}");
                    document.WriteParagraph($"HRESULT: {threadInfo.ExceptionInfo.HResult}");
                    WriteStackTraceTable(document, threadInfo.ExceptionInfo.StackFrameInfos);
                }

                document.WriteHeader4("Stack Trace");
                WriteStackTraceTable(document, threadInfo.StackFrameInfos);
            }

            // Objects
            const int objectsToTake = 1000;
            var topObjects = result.Objects
                .GroupBy(o => o.TypeName)
                .Select(infos => new
                {
                    Type = infos.Key,
                    Count = infos.Count(),
                    TotalSize = infos.Sum(info => (uint)info.Size)
                })
                .OrderByDescending(arg => arg.TotalSize)
                .Take(objectsToTake);

            document.WriteHeader2($"Top {objectsToTake} Objects by total size");
            document.WriteTable(
                topObjects,
                new[]
                {
                    "Type",
                    "Count",
                    "Total Size in bytes"
                },
                arg => (string.IsNullOrWhiteSpace(arg.Type) ? "UNKNOWN" : arg.Type).MakeInlineCode(),
                arg => arg.Count.ToString("n0"),
                arg => arg.TotalSize.ToString("n0")
            );

            Export(outputDirectory, document, "analysis-report");
        }

        public void GenerateCompareReport(CompareResult result, string outputDirectory)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));
            if (string.IsNullOrWhiteSpace(outputDirectory))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(outputDirectory));

            Log.Verbose("Generating compare report");

            var document = new MarkdownDocument();

            // Title
            document.WriteHeader1($"PostMortem Compare Report for {result.GeneralInfos.OlderDump.DumpFileName.MakeInlineCode()} and {result.GeneralInfos.NewerDump.DumpFileName.MakeInlineCode()}");
            document.WriteParagraph($"Report generated: {DateTime.Now:F}");

            // General Info
            document.WriteHeader2("General Information");
            document.WriteParagraph($"Older Dump File Creation Time: {result.GeneralInfos.OlderDump.DumpFileCreationTime:F}");
            document.WriteParagraph($"Older Dump File Path: {result.GeneralInfos.OlderDump.DumpFilePath.MakeInlineCode()}");
            document.WriteParagraph($"Newer Dump File Creation Time: {result.GeneralInfos.NewerDump.DumpFileCreationTime:F}");
            document.WriteParagraph($"Newer Dump File Path: {result.GeneralInfos.NewerDump.DumpFilePath.MakeInlineCode()}");

            // Matching threads
            document.WriteHeader2("Matching Threads");
            foreach (var matchingThread in result.MatchingThreads)
            {
                if(!matchingThread.MatchingFrames?.Any() ?? true) continue;

                var prefix = matchingThread.IsFullTraceMatch ? $"{MarkdownEmojis.Snowflake} " : null;
                document.WriteHeader3($"{prefix} Thread {matchingThread.ThreadFromOlder.OsThreadId.ToString("x12").MakeInlineCode()}");

                if (matchingThread.IsFullTraceMatch)
                {
                    document.WriteParagraph("Both stack traces seem to be equal".MakeMarked());
                }

                document.WriteHeader4("Matching stack frames");
                WriteStackTraceTable(document, matchingThread.MatchingFrames);
            }

            // Object Differences
            document.WriteHeader2("Object Count Differences");
            document.WriteTable(
                result.ObjectDiffs.OrderByDescending(info => info.Difference).Take(1000),
                new []
                {
                    "Type",
                    "Change"
                },
                info => info.ObjectInfo.TypeName.MakeInlineCode(),
                info =>
                {
                    var suffix = info.Difference > 0
                        ? $" {MarkdownEmojis.ArrowUpSmall} "
                        : null;
                    return $"{info.Difference?.ToString("N0")}{suffix}";
                });

            Export(outputDirectory, document, "compare-report");
        }

        private static void Export(string outputDirectory, MarkdownDocument document, string suffix)
        {
            var path = Path.Combine(outputDirectory, $"{Guid.NewGuid():D}-{suffix}");
            new Exporter().ExportFile(document.GetString(), $"{path}.md");
            new Exporter().ExportHtml(document, $"{path}.html");
        }

        private static void WriteStackTraceTable(MarkdownDocument document, IEnumerable<StackFrameInfo> frames)
        {
            document.WriteTable(
                frames,
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
    }
}