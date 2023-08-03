using System;
using System.Linq;
using System.Collections.Generic;

namespace Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int lowerBound = range[0];
            int upperBound = range[1];
            string command = Console.ReadLine();
            Func<int, bool> predicate = null;

            if (command == "odd")
            {
                predicate = x => x % 2 == 1 || x % 2 == -1;
            }
            else if (command == "even")
            {
                predicate = x => x % 2 == 0;
            }

            var finalNumbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicate(i))
                {
                    finalNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", finalNumbers));
        }
    }
}