using System;

namespace ExT08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfBeerKegs = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string kegName = string.Empty;
            for (int i = 0; i < numbersOfBeerKegs; i++)
            {
                string modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                double heightofTheKeg = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radiusOfTheKeg, 2) * heightofTheKeg;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = modelOfTheKeg;
                }
            }
            Console.WriteLine(kegName);
        }
    }
}
