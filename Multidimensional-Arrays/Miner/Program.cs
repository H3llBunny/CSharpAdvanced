using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var matrix = new string[size, size];
            int coalCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == "c")
                    {
                        coalCount++;
                    }
                }
            }

            int lastRow = 0;
            int lastCol = 0;
            bool check = false;

            for (int i = 0; i < commands.Length; i++)
            {
                bool answer = false;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == "s")
                        {
                            switch (commands[i])
                            {
                                case "up":
                                    if (row - 1 >= 0)
                                    {
                                        if (matrix[row - 1, col] == "*")
                                        {
                                            matrix[row - 1, col] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            lastRow = row - 1;
                                            lastCol = col;
                                            answer = true;
                                        }
                                        else if (matrix[row - 1, col] == "c")
                                        {
                                            matrix[row - 1, col] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            coalCount--;
                                            lastRow = row - 1;
                                            lastCol = col;
                                            answer = true;

                                            if (coalCount == 0)
                                            {
                                                Console.WriteLine($"You collected all coals! ({row - 1}, {col})");
                                                answer = true;
                                                check = true;
                                                break;
                                            }
                                        }
                                        else if (matrix[row - 1, col] == "e")
                                        {
                                            Console.WriteLine($"Game over! ({row - 1}, {col})");
                                            answer = true;
                                            check = true;
                                            break;
                                        }
                                    }
                                    break;

                                case "right":
                                    if (col + 1 < matrix.GetLength(1))
                                    {
                                        if (matrix[row, col + 1] == "*")
                                        {
                                            matrix[row, col + 1] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            lastRow = row;
                                            lastCol = col + 1;
                                            answer = true;
                                        }
                                        else if (matrix[row, col + 1] == "c")
                                        {
                                            matrix[row, col + 1] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            coalCount--;
                                            lastRow = row;
                                            lastCol = col + 1;
                                            answer = true;

                                            if (coalCount == 0)
                                            {
                                                Console.WriteLine($"You collected all coals! ({row}, {col + 1})");
                                                answer = true;
                                                check = true;
                                                break;
                                            }
                                        }
                                        else if (matrix[row, col + 1] == "e")
                                        {
                                            Console.WriteLine($"Game over! ({row}, {col + 1})");
                                            answer = true;
                                            check = true;
                                            break;
                                        }
                                    }
                                    break;

                                case "left":
                                    if (col - 1 >= 0)
                                    {
                                        if (matrix[row, col - 1] == "*")
                                        {
                                            matrix[row, col - 1] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            lastRow = row;
                                            lastCol = col - 1;
                                            answer = true;
                                        }
                                        else if (matrix[row, col - 1] == "c")
                                        {
                                            matrix[row, col - 1] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            coalCount--;
                                            lastRow = row;
                                            lastCol = col - 1;
                                            answer = true;

                                            if (coalCount == 0)
                                            {
                                                Console.WriteLine($"You collected all coals! ({row}, {col - 1})");
                                                answer = true;
                                                check = true;
                                                break;
                                            }
                                        }
                                        else if (matrix[row, col - 1] == "e")
                                        {
                                            Console.WriteLine($"Game over! ({row}, {col - 1})");
                                            answer = true;
                                            check = true;
                                            break;
                                        }
                                    }
                                    break;

                                case "down":
                                    if (row + 1 < matrix.GetLength(0))
                                    {
                                        if (matrix[row + 1, col] == "*")
                                        {
                                            matrix[row + 1, col] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            lastRow = row + 1;
                                            lastCol = col;
                                            answer = true;
                                        }
                                        else if (matrix[row + 1, col] == "c")
                                        {
                                            matrix[row + 1, col] = matrix[row, col];
                                            matrix[row, col] = "*";
                                            coalCount--;
                                            lastRow = row + 1;
                                            lastCol = col;
                                            answer = true;

                                            if (coalCount == 0)
                                            {
                                                Console.WriteLine($"You collected all coals! ({row + 1}, {col})");
                                                answer = true;
                                                check = true;
                                                break;
                                            }
                                        }
                                        else if (matrix[row + 1, col] == "e")
                                        {
                                            Console.WriteLine($"Game over! ({row + 1}, {col})");
                                            answer = true;
                                            check = true;
                                            break;
                                        }
                                    }
                                    break;
                            }
                        }
                        if (answer)
                        {
                            break;
                        }
                    }
                    if (answer)
                    {
                        answer = false;
                        break;
                    }
                }
            }

            if (!check)
            {
                Console.WriteLine($"{coalCount} coals left. ({lastRow}, {lastCol})");
            }
        }
    }
}