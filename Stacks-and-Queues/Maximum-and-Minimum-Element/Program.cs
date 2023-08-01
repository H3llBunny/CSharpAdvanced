using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];

                if (command == 1)
                {
                    stack.Push(input[1]);
                }
                else if (command == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Count > 0)
                {
                    int maxNum = stack.Max();
                    Console.WriteLine(maxNum);
                }
                else if (command == 4 && stack.Count > 0)
                {
                    int minNum = stack.Min();
                    Console.WriteLine(minNum);
                }
            }

            for (int i = 0; i < stack.Count; i++)
            {
                foreach (var num in stack)
                {
                    Console.Write(num);
                    i++;

                    if (i < stack.Count)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}