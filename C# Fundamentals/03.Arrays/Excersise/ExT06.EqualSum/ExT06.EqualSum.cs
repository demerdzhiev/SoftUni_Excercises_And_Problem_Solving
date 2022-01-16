using System;
using System.Linq;

namespace ExT06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int sumLeft = i; sumLeft  > 0; sumLeft --)
                {
                    int nextElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }
                rightSum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextEementPosition = (j + 1);
                    if (j < numbers.Length - 1)
                    {
                        rightSum += numbers[nextEementPosition];
                    }
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
