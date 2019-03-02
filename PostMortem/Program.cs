namespace PostMortem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args);
        }
    }
}
