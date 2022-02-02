using System;
using System.Linq;

namespace T05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snakeSymbols = Console.ReadLine();

            char[,] matrix = new char[rowCol[0], rowCol[1]];

            bool rightToLeft = true;
            int indexOfSymbol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (rightToLeft)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeSymbols[indexOfSymbol++];

                        if (indexOfSymbol== snakeSymbols.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                    rightToLeft = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeSymbols[indexOfSymbol++];

                        if (indexOfSymbol == snakeSymbols.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                    rightToLeft = true;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
