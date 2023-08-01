using System;
using System.Linq;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int difference = 0;
            int diagonalSum = 0;
            int diagonalSum2 = 0;
            int reverseIndex = cols - 1;

            for (int i = 0; i < cols; i++)
            {
                diagonalSum += matrix[i, i];
                diagonalSum2 += matrix[i, reverseIndex];
                reverseIndex--;
            }

            difference = Math.Abs(diagonalSum - diagonalSum2);
            Console.WriteLine(difference);
        }
    }
}