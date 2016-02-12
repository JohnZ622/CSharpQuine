using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuine
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"using System;
                        using System.Collections.Generic;
                        using System.Linq;
                        using System.Text;
                        using System.Threading.Tasks;
                        
                        namespace CSharpQuine
                        {
                            class Program
                            {
                                static void Main(string[] args)
                                {
                                    string s = @""";
            string b = @"            Console.Write(ProcessString(s) + s.Replace(""\"""", ""\""\""""));
                                    Console.WriteLine(""\"";"");
                                    Console.Write(""            string b = @\"""");
                                    Console.Write(b.Replace(""\"""", ""\""\""""));
                                    Console.Write(""\"";\r\n            "");
                                    Console.Write(ProcessString(b));
                                }
                                
                                static string ProcessString(string input)
                                {
                                    StringBuilder outputBuilder = new StringBuilder();
                                    bool skippedFirst = false;
                                    foreach (string line in input.Split(new string [] {Environment.NewLine}, StringSplitOptions.None))
                                    {
                                        if (!skippedFirst)
                                        {
                                            skippedFirst = true;
                                            outputBuilder.AppendLine(line);
                                            continue;
                                        }
                                        outputBuilder.AppendLine(line.Substring(24));
                                    }
                                    return outputBuilder.ToString().Trim();
                                }
                            }
                        }";
            Console.Write(ProcessString(s) + s.Replace("\"", "\"\""));
            Console.WriteLine("\";");
            Console.Write("            string b = @\"");
            Console.Write(b.Replace("\"", "\"\""));
            Console.Write("\";\r\n            ");
            Console.Write(ProcessString(b));
        }

        static string ProcessString(string input)
        {
            StringBuilder outputBuilder = new StringBuilder();
            bool skippedFirst = false;
            foreach (string line in input.Split(new string [] {Environment.NewLine}, StringSplitOptions.None))
            {
                if (!skippedFirst)
                {
                    skippedFirst = true;
                    outputBuilder.AppendLine(line);
                    continue;
                }
                outputBuilder.AppendLine(line.Substring(24));
            }
            return outputBuilder.ToString().Trim();
        }
    }
}