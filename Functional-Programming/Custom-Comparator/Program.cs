using System;
using System.Linq;
using System.Collections.Generic;

namespace Custom_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> evenCheck = x => x % 2 == 0;
            Func<int, bool> oddCheck = x => x % 2 != 0;

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var sortedEvenNumbers = new int[] { };
            var sortedOddNumbers = new int[] { };

            sortedEvenNumbers = numbers.Where(evenCheck).ToArray();
            Array.Sort(sortedEvenNumbers);
            sortedOddNumbers = numbers.Where(oddCheck).ToArray();
            Array.Sort(sortedOddNumbers);

            var orderedNumbers = new List<int>();

            orderedNumbers.AddRange(sortedEvenNumbers);
            orderedNumbers.AddRange(sortedOddNumbers);

            Console.WriteLine(string.Join(" ", orderedNumbers));
        }
    }
}