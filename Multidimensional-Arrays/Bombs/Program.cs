using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Bombs
{
    internal class Program
    {
        class BombCoordinates
        {
            public BombCoordinates(int bombRow, int bombCol)
            {
                Row = bombRow;
                Col = bombCol;
            }

            public int Row { get; set; }
            public int Col { get; set; }
        }

        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            var matrix = new int[dimension, dimension];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            var bombCoordinates = new List<BombCoordinates>();

            int[] bombs = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < bombs.Length - 1; i++)
            {
                int bombRow = bombs[i];
                int bombCol = bombs[i + 1];
                bombCoordinates.Add(new BombCoordinates(bombRow, bombCol));
                i++;
            }

            foreach (var bomb in bombCoordinates)
            {
                int bombRow = bomb.Row;
                int bombCol = bomb.Col;

                if (matrix[bombRow, bombCol] > 0)
                {
                    if (bombRow - 1 >= 0)
                    {
                        if (bombCol - 1 >= 0)
                        {
                            if (matrix[bombRow - 1, bombCol - 1] > 0)
                            {
                                matrix[bombRow - 1, bombCol - 1] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol < matrix.GetLength(1))
                        {
                            if (matrix[bombRow - 1, bombCol] > 0)
                            {
                                matrix[bombRow - 1, bombCol] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol + 1 < matrix.GetLength(1))
                        {
                            if (matrix[bombRow - 1, bombCol + 1] > 0)
                            {
                                matrix[bombRow - 1, bombCol + 1] -= matrix[bombRow, bombCol];
                            }
                        }
                    }

                    if (bombRow >= 0)
                    {
                        if (bombCol - 1 >= 0)
                        {
                            if (matrix[bombRow, bombCol - 1] > 0)
                            {
                                matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol + 1 < matrix.GetLength(1))
                        {
                            if (matrix[bombRow, bombCol + 1] > 0)
                            {
                                matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol];
                            }
                        }
                    }

                    if (bombRow + 1 < matrix.GetLength(0))
                    {
                        if (bombCol - 1 >= 0)
                        {
                            if (matrix[bombRow + 1, bombCol - 1] > 0)
                            {
                                matrix[bombRow + 1, bombCol - 1] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol < matrix.GetLength(1))
                        {
                            if (matrix[bombRow + 1, bombCol] > 0)
                            {
                                matrix[bombRow + 1, bombCol] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol + 1 < matrix.GetLength(1))
                        {
                            if (matrix[bombRow + 1, bombCol + 1] > 0)
                            {
                                matrix[bombRow + 1, bombCol + 1] -= matrix[bombRow, bombCol];
                            }
                        }
                    }
                    matrix[bombRow, bombCol] = 0;
                }
            }

            int counter = 0;
            int sum = 0;

            foreach (var number in matrix)
            {
                if (number > 0)
                {
                    counter++;
                    sum += number;
                }
            }

            Console.WriteLine("Alive cells: {0}", counter);
            Console.WriteLine("Sum: {0}", sum);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}