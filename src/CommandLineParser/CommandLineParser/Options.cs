using System.Text;
using CommandLine;
using CommandLine.Text;

namespace CommandLineParser
{
    public class Options
    {
        [Option('t', "test", Required = true, HelpText = "Test Option")]
        public string Test { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}