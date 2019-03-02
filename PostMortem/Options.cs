using CommandLine;

namespace PostMortem
{
    public class Options
    {
        [Option(
            'p', "path",
            HelpText = "Path to the memory dump",
            Required = true)]
        public string Path { get; set; }

        [Option(
            'v', "verbose",
            HelpText = "Verbose output",
            Required = false,
            Default = false)]
        public bool Verbose { get; set; }
    }
}
