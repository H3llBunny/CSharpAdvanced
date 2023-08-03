using System;
using System.Linq;

namespace Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length <= n);

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}