using System;
using System.Linq;
using System.Collections.Generic;

namespace List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var divisors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, bool> isDivisibleByAny = (num) => divisors.All(x => num % x == 0);

            List<int> divisibleNumbers = Enumerable.Range(1, n).Where(isDivisibleByAny).ToList();

            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }
    }
}