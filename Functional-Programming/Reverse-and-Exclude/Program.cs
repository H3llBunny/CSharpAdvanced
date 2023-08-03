using System;
using System.Linq;

namespace Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            int divider = int.Parse(Console.ReadLine());

            numbers = numbers.Where(x => x % divider != 0).Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}