using MatthiWare.CommandLine;
using System;
using System.IO;
using System.Text;

namespace ConvertToBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineParserOptions
            {
                AppName = "CLI",
            };
            var parser = new CommandLineParser<ProgramOptions>();
            var result = parser.Parse(args);
            if (result.HasErrors)
            {
                Console.WriteLine("Parsing has error");
                return;
            }
            var programOptions = result.Result;


            byte[] input = File.ReadAllBytes(programOptions.Input);
            string output = Convert.ToHexString(input);

            var path = Directory.GetCurrentDirectory();
            var fileName = programOptions.Output;
            var fileLocation = Path.Combine(path, fileName);

            string outputinInts = string.Empty;
            Console.WriteLine(input.Length);
            foreach (var b in input)
            {
                int intValue = Convert.ToInt32(b);
                outputinInts += intValue+"-";
            }

            using (StreamWriter sw = File.CreateText(fileLocation))
            {
                sw.WriteLine(output);
                sw.WriteLine(outputinInts);
            }
            Console.WriteLine($"File location is {fileLocation}");
        }
    }
}
