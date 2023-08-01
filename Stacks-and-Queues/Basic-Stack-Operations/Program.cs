using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int popCount = input[1];
            int number = input[2];
            var numbers = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            bool check = false;

            for (int i = 0; i < popCount; i++)
            {
                numbers.Pop();
            }

            foreach (var num in numbers)
            {
                if(num == number)
                {
                    check = true;
                    Console.WriteLine("true");
                }
            }

            if(numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(numbers.Count > 0 && !check)
            {
                int minNum = numbers.Min();
                Console.WriteLine(minNum);
            }
        }
    }
}