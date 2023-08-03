using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (wardrobe.ContainsKey(color))
                {
                    for (int j = 1; j < input.Length; j++)
                    {
                        string item = input[j];

                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    for (int j = 1; j < input.Length; j++)
                    {
                        string item = input[j];

                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
            }

            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string theColor = command[0];
            string clothing = command[1];

            foreach (var col in wardrobe)
            {
                bool colorCheck = false;

                Console.WriteLine($"{col.Key} clothes:");

                if (col.Key == theColor)
                {
                    colorCheck = true;
                }

                foreach (var item in col.Value)
                {
                    if (item.Key == clothing && colorCheck)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}