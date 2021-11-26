using System;

namespace ExT02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int value = firstNum; value <= secondNum; value++)
            {
                int currNum = value;
                int oddSum = 0;
                int evenSum = 0;
                int count = 0;
                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                    currNum = currNum / 10;
                    count++;
                }
                if (oddSum == evenSum)
                {
                    Console.Write(value + " ");
                }
            }
        }
    }
}
