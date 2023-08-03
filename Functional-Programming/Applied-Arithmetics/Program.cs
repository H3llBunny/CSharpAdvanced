using System;
using System.Linq;

namespace Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            Func<int, int> predicate = null;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        predicate = x => x + 1;
                        numbers = numbers.Select(predicate);
                        break;

                    case "multiply":
                        predicate = x => x * 2;
                        numbers = numbers.Select(predicate);
                        break;

                    case "subtract":
                        predicate = x => x - 1;
                        numbers = numbers.Select(predicate);
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;

                    default:
                        break;
                }
            }
        }
    }
}