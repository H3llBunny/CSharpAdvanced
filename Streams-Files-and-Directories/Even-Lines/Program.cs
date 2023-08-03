using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Even_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"[-,.!?]+");
            using (var reader = new StreamReader("text.txt"))
            {
                int counter = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    line = pattern.Replace(line, "@");
                    var stack = new Stack<string>(line.Split(" ", StringSplitOptions.RemoveEmptyEntries));

                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(string.Join(" ", stack));
                    }

                    counter++;
                }
            }
        }
    }
}