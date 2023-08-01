using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedLit = 0;
            int bottleCount = 0;
            int cupCount = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (cups.Peek() <= bottles.Peek())
                {
                    wastedLit += bottles.Peek() - cups.Peek();
                    cups.Dequeue();
                    cupCount++;
                    bottles.Pop();
                    bottleCount++;

                }
                else if (cups.Peek() > bottles.Peek())
                {
                    int tmpCup = cups.Peek();
                    tmpCup -= bottles.Pop();
                    bottleCount++;

                    while (tmpCup > 0)
                    {
                        if (tmpCup > bottles.Peek())
                        {
                            tmpCup -= bottles.Pop();
                            bottleCount++;
                        }
                        else if (tmpCup <= bottles.Peek())
                        {
                            wastedLit += bottles.Pop() - tmpCup;
                            bottleCount++;
                            cups.Dequeue();
                            cupCount++;
                            tmpCup = 0;
                        }
                    }
                }
            }

            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedLit}");
            }
            else if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLit}");
            }
        }
    }
}