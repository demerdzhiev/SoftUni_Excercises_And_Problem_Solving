using System;

namespace ExT08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); //A12b
            double sum = 0;
            foreach (string item in input)
            {
                char firstLetter = item[0]; // =>A
                char lastLetter = item[^1]; //[^1] == [item.Lenght - 1] =>b
                string numAsAAstring = item[1..^1]; // this gives us everything that is between 1st and last index =>12
                double numFromString = double.Parse(numAsAAstring);
                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    numFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
