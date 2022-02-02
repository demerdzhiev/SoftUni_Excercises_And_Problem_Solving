using System;
using System.Linq;

namespace T01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum1 += matrix[i, i];
                sum2 += matrix[i, matrix.GetLength(1) - 1 - i];
            }

            Console.WriteLine(Math.Abs(sum2 - sum1));
        }
    }
}
