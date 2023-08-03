using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charCounter = new SortedDictionary<char, int>();

            foreach (var c in input)
            {
                if(charCounter.ContainsKey(c))
                {
                    charCounter[c]++;
                }
                else
                {
                    charCounter.Add(c, 1);
                }
            }

            foreach (var c in charCounter)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}