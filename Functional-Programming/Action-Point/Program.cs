using System;
using System.Linq;

namespace Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = x => Console.WriteLine(x);
            for (int i = 0; i < input.Length; i++)
            {
                print(input[i]);
            }
        }
    }
}