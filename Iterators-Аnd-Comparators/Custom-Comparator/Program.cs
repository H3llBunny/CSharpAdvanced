using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] evenNums = numbers.Where(x => x % 2 == 0).ToArray();
            int[] oddNums = numbers.Where(x => x % 2 != 0).ToArray();

            Array.Sort(evenNums);
            Array.Sort(oddNums);

            var sortedNumbers = new List<int>{};
            sortedNumbers.AddRange(evenNums);
            sortedNumbers.AddRange(oddNums);

            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}