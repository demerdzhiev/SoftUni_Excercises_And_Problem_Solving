using System;
using System.Linq;

namespace ExT05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                bool currentIterationNumIsBigger = true;
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        currentIterationNumIsBigger = false;
                    }
                }
                if (currentIterationNumIsBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }
            }
        }

    }
}
