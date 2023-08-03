﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) =>
            arr.FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, n, isValidWord);

            Console.WriteLine(result);
        }
    }
}