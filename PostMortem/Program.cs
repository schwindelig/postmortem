using System;
using CommandLine;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace PostMortem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                InitSerilog(options.Verbose);

                try
                {
                    throw new NotImplementedException();
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
