using System;

namespace CommandLineParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            var argsParsed = CommandLine.Parser.Default.ParseArguments(args, options);

            if ((!string.Equals(args[0], "--help") && !string.Equals(args[0], "-h")) && args.Length == 1)
            {
                if (!argsParsed)
                    throw new ArgumentException("Command line arguments could not be parsed ...");
            }
            
            Console.WriteLine(options.Test);

            Console.WriteLine("Press ENTER to continue ...");
            Console.ReadLine();
        }
    }
}
