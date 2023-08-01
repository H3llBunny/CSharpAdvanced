using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Snake_Moves
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new char[input[0], input[1]];
            var queueSnake = new Queue<char>(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row % 2 == 0)
                    {
                        char currentSymbol = queueSnake.Peek();
                        matrix[row, col] = currentSymbol;
                        queueSnake.Enqueue(queueSnake.Dequeue());
                    }

                    else if (row % 2 != 0)
                    {
                        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                        {
                            char currentSymbol = queueSnake.Peek();
                            matrix[row, j] = currentSymbol;
                            queueSnake.Enqueue(queueSnake.Dequeue());
                        }

                        break;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}