using System;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int sumOfPositions = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a' || inputString[i] == 'A')
                {
                    sumOfPositions += 1;
                }
                else if (inputString[i] == 'e' || inputString[i] == 'E')
                {
                    sumOfPositions += 1;
                }
                else if (inputString[i] == 'i' || inputString[i] == 'I')
                {
                    sumOfPositions += 1;
                }
                else if (inputString[i] == 'o' || inputString[i] == 'O')
                {
                    sumOfPositions += 1;
                }
                else if (inputString[i] == 'u' || inputString[i] == 'U')
                {
                    sumOfPositions += 1;
                }
            }
            Console.WriteLine(sumOfPositions);
        }
    }
}