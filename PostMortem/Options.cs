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

        [Option(
            'o', "output-dir",
            HelpText = "Directory where the analysis result should be saved",
            Required = true)]
        public string OutputDirectory { get; set; }

        [Option(
            's', "p2",
            HelpText = "Path to the second memory dump",
            Required = false)]
        public string Path2 { get; set; }
    }
}
