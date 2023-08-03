using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letterCheck = new Regex(@"[A-Za-z]+");
            var punctuationCheck = new Regex(@"[-,.'""!?]+");

            using (var reader = new StreamReader("text.txt"))
            {
                int lineCount = 1;

                while (!reader.EndOfStream)
                {
                    int letterCount = 0;
                    int punctuationCount = 0;
                    string line = reader.ReadLine();
                    var chars = line.ToCharArray();

                    foreach (var c in chars)
                    {
                        if (letterCheck.IsMatch(c.ToString()))
                        {
                            letterCount++;
                        }
                        else if (punctuationCheck.IsMatch(c.ToString()))
                        {
                            punctuationCount++;
                        }
                    }

                    File.AppendAllText("output.txt", $"Line {lineCount}: {line} ({letterCount})({punctuationCount})\n");
                    lineCount++;
                }
            }
        }
    }
}