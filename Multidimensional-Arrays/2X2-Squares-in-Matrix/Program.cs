using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            if (rows >= 2 && cols >= 2)
            {
                var matrix = new char[rows, cols];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    char[] characters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = characters[j];
                    }
                }

                int squareCount = 0;

                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        if (matrix[i, j] == matrix[i, j + 1] &&
                            matrix[i + 1, j] == matrix[i + 1, j + 1] &&
                            matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            squareCount++;
                        }
                    }
                }

                Console.WriteLine(squareCount);
            }
        }
    }
}