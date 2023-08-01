using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int expenceSum = 0;
            int barrelCount = 0;

            while(bullets.Count > 0 && locks.Count > 0)
            {
                for (int i = 0; i < gunBarrel; i++)
                {
                    if (bullets.Count > 0 && locks.Count > 0)
                    {
                        if (bullets.Peek() <= locks.Peek())
                        {
                            bullets.Pop();
                            locks.Dequeue();
                            expenceSum += bulletPrice;
                            barrelCount++;
                            Console.WriteLine("Bang!");
                        }
                        else
                        {
                            bullets.Pop();
                            expenceSum += bulletPrice;
                            barrelCount++;
                            Console.WriteLine("Ping!");
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if(bullets.Count > 0 && barrelCount < gunBarrel && locks.Count == 0)
                {
                    if(locks.Count == 0)
                    {
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - expenceSum}");

                        break;
                    }
                }
                else if(bullets.Count > 0 && barrelCount == gunBarrel)
                {
                    Console.WriteLine("Reloading!");

                    barrelCount = 0;

                    if(locks.Count == 0)
                    {
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - expenceSum}");

                        break;
                    }
                }
                else if(bullets.Count > 0 && locks.Count == 0 || bullets.Count == 0 && locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - expenceSum}");

                    break;
                }
                else if(bullets.Count == 0 && locks.Count > 0 )
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");

                    break;
                }
            }
        }
    }
}