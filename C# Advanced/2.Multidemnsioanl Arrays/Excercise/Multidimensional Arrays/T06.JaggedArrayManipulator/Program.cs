using System;
using System.Linq;

namespace T06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] array = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                array[row] = ConsoleParse();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (array[row].Length == array[row + 1].Length)
                {
                    array[row] = Multiplier(array[row]);
                    array[row + 1] = Multiplier(array[row + 1]);
                }
                else if (array[row].Length != array[row + 1].Length)
                {
                    array[row] = Divider(array[row]);
                    array[row + 1] = Divider(array[row + 1]);
                }
            }

            string command = Console.ReadLine();

            while (true)
            {
                string[] cmdSplit = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdSplit[0] == "Add")
                {
                    int row = int.Parse(cmdSplit[1]);
                    int col = int.Parse(cmdSplit[2]);
                    double value = double.Parse(cmdSplit[3]);
                    if ((row >= 0 && row < array.Length) && (col >= 0 && col < array[row].Length))
                    {
                        array[row][col] = AddOperator(array[row][col], value);
                    }
                }
                else if (cmdSplit[0] == "Subtract")
                {
                    int row = int.Parse(cmdSplit[1]);
                    int col = int.Parse(cmdSplit[2]);
                    double value = double.Parse(cmdSplit[3]);
                    if ((row >= 0 && row < array.Length) && (col >= 0 && col < array[row].Length))
                    {
                        array[row][col] = SubOperator(array[row][col], value);
                    }
                }
                else if (cmdSplit[0] == "End")
                {
                    foreach (var row in array)
                    {
                        Console.Write(string.Join(" ", row));
                        Console.WriteLine();
                    }
                    break;
                }

                command = Console.ReadLine();
            }
        }

        static double AddOperator(double number, double value) =>
            number += value;

        static double SubOperator(double number, double value) =>
            number -= value;

        static double[] ConsoleParse() =>
            Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        static double[] Multiplier(double[] array) =>
            array = array
            .Select(x => x * 2)
            .ToArray();

        static double[] Divider(double[] array) =>
            array = array
            .Select(x => x / 2)
            .ToArray();
    }
}
