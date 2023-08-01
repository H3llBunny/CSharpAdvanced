using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int dequeueCount = input[1];
            int number = input[2];
            bool check = false;

            for (int i = 0; i < dequeueCount; i++)
            {
                numbers.Dequeue();
            }

            foreach (var num in numbers)
            {
                if (num == number)
                {
                    check = true;
                    Console.WriteLine("true");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (numbers.Count > 0 && !check)
            {
                int minNum = numbers.Min();
                Console.WriteLine(minNum);
            }
        }
    }
}