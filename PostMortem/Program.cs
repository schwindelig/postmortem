﻿using System;
using System.IO;
using CommandLine;
using PostMortem.Core;
using PostMortem.Core.Analyse;
using PostMortem.Core.Compare;
using PostMortem.Core.Report;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace PostMortem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                InitSerilog(options.Verbose);

                try
                {
                    using (var analyser = new Analyser())
                    {
                        //var startTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");

                        var resultLeft = analyser.RunAnalysis(new AnalyserOptions
                        {
                            Path = options.Path
                        });
                        new Reporter().GenerateAnalysisReport(resultLeft,options.OutputDirectory);

                        if (!string.IsNullOrWhiteSpace(options.Path2))
                        {
                            var resultRight = analyser.RunAnalysis(new AnalyserOptions
                            {
                                Path = options.Path2
                            });
                            new Reporter().GenerateAnalysisReport(resultRight, options.OutputDirectory);

                            var compareResult = new Comparer().CompareResults(resultLeft, resultRight);
                            new Reporter().GenerateCompareReport(compareResult, options.OutputDirectory);
                        }

                        //var targetPath = Path.Combine(options.OutputDirectory, $"{startTimeStamp}.json");

                        //new Exporter().ExportData(result, targetPath);
                        //Log.Information("Saved result to {targetPath}", targetPath);
                    }
                }
                catch (Exception exception)
                {
                    Log.Fatal(exception, "Failed to run analysis with options: {@options}", options);
                }

                CloseSerilog();
            });
        }

        private static void CloseSerilog()
        {
            Log.CloseAndFlush();
        }

        private static void InitSerilog(bool isVerbose)
        {
            var levelSwitch = new LoggingLevelSwitch(isVerbose ? LogEventLevel.Verbose : LogEventLevel.Information);

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .WriteTo.Console()
                .CreateLogger();

            Log.Verbose("Initialized logger");
        }
    }
}
