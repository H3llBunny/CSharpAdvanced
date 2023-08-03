using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new HashSet<int>();
            var evenNumCounter = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.Add(number))
                {
                    if (!evenNumCounter.ContainsKey(number))
                    {
                        evenNumCounter.Add(number, 0);
                    }
                    else
                    {
                        evenNumCounter[number]++;
                    }
                }
            }

            foreach (var count in evenNumCounter)
            {
                if (count.Value % 2 == 0)
                {
                    Console.WriteLine(count.Key);
                }
            }
        }
    }
}