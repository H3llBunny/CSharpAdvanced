using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < n[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            var finalSet = new HashSet<int>();

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    finalSet.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}