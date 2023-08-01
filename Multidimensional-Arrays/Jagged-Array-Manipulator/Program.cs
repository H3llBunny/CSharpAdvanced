using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagMatrix = new double[rows][];

            for (int row = 0; row < jagMatrix.Length; row++)
            {
                double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jagMatrix[row] = new double[numbers.Length];

                for (int col = 0; col < jagMatrix[row].Length; col++)
                {
                    jagMatrix[row][col] = numbers[col];
                }
            }

            for (int row = 0; row < jagMatrix.Length - 1; row++)
            {
                if (jagMatrix[row].Length == jagMatrix[row + 1].Length)
                {
                    for (int col = 0; col < jagMatrix[row].Length; col++)
                    {
                        jagMatrix[row][col] *= 2;
                        jagMatrix[row + 1][col] *= 2;
                    }
                }
                else if (jagMatrix[row].Length != jagMatrix[row + 1].Length)
                {
                    for (int col = 0; col < jagMatrix[row].Length; col++)
                    {
                        jagMatrix[row][col] /= 2;
                    }
                    for (int col2 = 0; col2 < jagMatrix[row + 1].Length; col2++)
                    {
                        jagMatrix[row + 1][col2] /= 2;
                    }
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = double.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if ((row >= 0 && row < jagMatrix.Length) && (col >= 0 && col < jagMatrix[row].Length))
                    {
                        jagMatrix[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if ((row >= 0 && row < jagMatrix.Length) && (col >= 0 && col < jagMatrix[row].Length))
                    {
                        jagMatrix[row][col] -= value;
                    }
                }
            }

            foreach (var row in jagMatrix)
            {
                Console.Write(string.Join(" ", row));
                Console.WriteLine();
            }
        }
    }
}
