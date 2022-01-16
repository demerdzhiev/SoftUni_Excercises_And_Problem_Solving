using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    arr = ExchangeArr(arr, int.Parse(command[1]));
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMinMax(arr, command[0], command[1]);
                }
                else
                {
                    FindNumbers(arr, command[0], int.Parse(command[1]), command[2]);
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static int[] ExchangeArr(int[] currentArray, int splitIndex)
        {
            if (splitIndex >= currentArray.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return currentArray;
            }

            int[] exchagedArray = new int[currentArray.Length];
            int index = 0;
            for (int currentIndex = splitIndex + 1; currentIndex < currentArray.Length; currentIndex++)
            {
                exchagedArray[index] = currentArray[currentIndex];
                index++;
            }

            for (int curIndex = 0; curIndex <= splitIndex; curIndex++)
            {
                exchagedArray[index] = currentArray[curIndex];
                index++;
            }

            return exchagedArray;
        }

        static void FindMinMax(int[] currArray, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;

            int resultOddEven = 1;

            if (evenOrOdd == "even") resultOddEven = 0;

            for (int currIndex = 0; currIndex < currArray.Length; currIndex++)
            {
                if (currArray[currIndex] % 2 == resultOddEven)
                {
                    if (minOrMax == "min" && min >= currArray[currIndex])
                    {
                        min = currArray[currIndex];
                        index = currIndex;
                    }
                    else if (minOrMax == "max" && max <= currArray[currIndex])
                    {
                        max = currArray[currIndex];
                        index = currIndex;
                    }
                }
            }

            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
        }

        static void FindNumbers(int[] currArray, string position, int numbersCount, string evenOdd)
        {
            if (numbersCount > currArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (numbersCount == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            int resultEvenOdd = 1;
            if (evenOdd == "even") resultEvenOdd = 0;

            int count = 0;
            List<int> nums = new List<int>();

            if (position == "first")
            {
                foreach (var num in currArray)
                {
                    if (num % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(num);
                    }

                    if (count == numbersCount) break;

                }
            }
            else
            {
                for (int currenIndex = currArray.Length - 1; currenIndex >= 0; currenIndex--)
                {
                    if (currArray[currenIndex] % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(currArray[currenIndex]);
                    }
                    if (count == numbersCount) break;
                }

                nums.Reverse();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
