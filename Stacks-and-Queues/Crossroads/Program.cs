using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = string.Empty;
            var cars = new Queue<string>();
            var carChar = new Queue<char>();
            int counter = 0;
            char stuckChar = new char();
            bool stuckCharCheck = false;
            bool finalCheck = false;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if (input == "green")
                {
                    if (stuckCharCheck)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{cars.Peek()} was hit at {stuckChar}.");
                        finalCheck = true;
                        break;
                    }

                    bool check = false;

                    if (cars.Count > 0)
                    {
                        foreach (var @char in cars.Peek())
                        {
                            carChar.Enqueue(@char);
                        }

                        for (int i = 0; i <= greenLight; i++)
                        {
                            if (carChar.Count > 0 && i < greenLight)
                            {
                                carChar.Dequeue();
                            }
                            else if (carChar.Count == 0)
                            {
                                counter++;
                                cars.Dequeue();
                                stuckChar = new char();

                                if (i < greenLight && cars.Count > 0)
                                {
                                    i--;

                                    foreach (var @char in cars.Peek())
                                    {
                                        carChar.Enqueue(@char);
                                    }
                                }
                                else if (i == greenLight && carChar.Count > 0)
                                {
                                    check = true;
                                    break;
                                }
                                else if (carChar.Count == 0)
                                {
                                    break;
                                }
                            }
                            else if (i == greenLight && carChar.Count > 0)
                            {
                                check = true;
                                break;
                            }
                        }
                    }

                    if (check)
                    {
                        for (int i = 0; i <= freeWindow; i++)
                        {
                            if (carChar.Count > 0 && i < freeWindow)
                            {
                                carChar.Dequeue();
                            }
                            else if (i <= freeWindow && carChar.Count == 0)
                            {
                                cars.Dequeue();
                                counter++;
                                break;
                            }
                            else if (i == freeWindow && carChar.Count > 0)
                            {
                                stuckChar = carChar.Peek();
                                stuckCharCheck = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!stuckCharCheck)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
            else if (!finalCheck)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{cars.Peek()} was hit at {stuckChar}.");
            }
        }
    }
}