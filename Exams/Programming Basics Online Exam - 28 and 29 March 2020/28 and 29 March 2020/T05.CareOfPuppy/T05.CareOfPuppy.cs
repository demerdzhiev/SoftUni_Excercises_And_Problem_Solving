using System;

namespace T05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            string input = (Console.ReadLine());
            double eatenFoodPerDay = 0;
            double totalEatenFOod = 0;
            double foodInGrams = food * 1000;

            while (true)
            {
                eatenFoodPerDay = double.Parse(input);
                totalEatenFOod += eatenFoodPerDay;
                input = (Console.ReadLine());

                if (input == "Adopted")
                {
                    if (foodInGrams >= totalEatenFOod)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - totalEatenFOod} grams.");
                    }
                    else
                    {
                        Console.WriteLine($"Food is not enough. You need {totalEatenFOod - foodInGrams} grams more.");
                    }
                    return;
                }
            }   
        }
    }
}
