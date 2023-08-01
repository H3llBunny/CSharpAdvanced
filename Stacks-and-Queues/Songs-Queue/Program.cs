using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(", "));

            while(queue.Count > 0)
            {
                string input = Console.ReadLine();

                if(input.Contains("Play") && queue.Count > 0)
                {
                    queue.Dequeue();
                }
                else if(input.Contains("Add"))
                {
                    input = input.Remove(0, 4);
                    string songName = input;

                    if (queue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songName);
                    }
                }
                else if(input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}