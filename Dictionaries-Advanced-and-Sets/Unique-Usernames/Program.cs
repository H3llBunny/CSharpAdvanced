using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nameList = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                nameList.Add(Console.ReadLine());
            }

            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
        }
    }
}