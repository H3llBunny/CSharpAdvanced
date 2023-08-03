using System;
using System.Linq;

namespace Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int> minNum = x => x.Min();

            int minNumber = minNum(input);

            Console.WriteLine(minNumber);
        }
    }
}