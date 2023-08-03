using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameList = Console.ReadLine().Split().ToList();
            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input.Split().ToList();
                string command = tokens[0];
                var predicate = GetPredicate(tokens[1], tokens[2]);

                switch (command)
                {
                    case "Remove":
                        nameList.RemoveAll(predicate);
                        break;

                    case "Double":
                        var matches = nameList.FindAll(predicate);
                        var indexes = new List<int>();

                        foreach (var match in matches)
                        {
                            var index = nameList.FindIndex(predicate);
                            indexes.Add(index);
                        }

                        for (int i = indexes.Count - 1; i >= 0; i--)
                        {
                            nameList.Insert(indexes[i], matches[i]);
                        }
                        break;
                }
            }

            if (nameList.Count != 0)
            {
                Console.WriteLine(string.Join(", ", nameList) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string commandType, string arg)
        {
            switch (commandType)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(arg);

                case "EndsWith":
                    return (name) => name.EndsWith(arg);

                case "Length":
                    return (name) => name.Length == int.Parse(arg);

                default:
                    throw new ArgumentException("Invalid command type: " + commandType);
            }
        }
    }
}