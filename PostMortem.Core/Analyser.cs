using System;
using System.IO;
using PostMortem.Core.Exceptions;
using Serilog;

namespace PostMortem.Core
{
    public class Analyser
    {
        public void RunAnalysis(AnalyserOptions options)
        {
            try
            {
                ValidateOptions(options);
            }
            catch (InvalidOptionsException exception)
            {
                Log.Error(exception, "Provided analyser options are invalid");
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Error while validating options");
            }
        }

        private static void ValidateOptions(AnalyserOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.Path)) throw new InvalidOptionsException("No path defined");

            if(!File.Exists(options.Path)) throw new InvalidOptionsException($"Dump File does not exist: {options.Path}");

            Log.Verbose("Analyser Options valid: {@options}", options);
        }
    }
}
