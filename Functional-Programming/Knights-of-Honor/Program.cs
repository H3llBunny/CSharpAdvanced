using System;
using System.Linq;

namespace Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> printSir = x => Console.WriteLine("Sir " + x);

            for (int i = 0; i < input.Length; i++)
            {
                printSir(input[i]);
            }
        }
    }
}