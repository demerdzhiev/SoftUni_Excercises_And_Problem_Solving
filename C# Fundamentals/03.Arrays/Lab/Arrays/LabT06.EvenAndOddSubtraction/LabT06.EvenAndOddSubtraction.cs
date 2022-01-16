using System;
using System.Linq;

namespace LabT06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdds = 0;
            int sumEvens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    sumOdds += currentNumber;
                }
                else
                {
                    sumEvens += currentNumber;
                }
            }

            Console.WriteLine(sumOdds - sumEvens);
        }
    }
}
