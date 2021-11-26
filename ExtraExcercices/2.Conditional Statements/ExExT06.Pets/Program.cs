using System;

namespace ExExT06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodTotal = double.Parse(Console.ReadLine());
            double dogFoofPerDay = double.Parse(Console.ReadLine());
            double catFoofPerDay = double.Parse(Console.ReadLine());
            double turtleFoodInGramsPerDay = double.Parse(Console.ReadLine());

            double turtleFoodPerDay = turtleFoodInGramsPerDay / 1000;
            double foodNeededPerDay = dogFoofPerDay + catFoofPerDay + turtleFoodPerDay;
            double totalFoodNeeded = foodNeededPerDay * days;

            if (foodTotal >= totalFoodNeeded)
            {
                double foodLeft = Math.Floor(foodTotal - totalFoodNeeded);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else if (foodTotal < totalFoodNeeded)
            {
                double foodNeeded = Math.Ceiling(totalFoodNeeded - foodTotal);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }


        }
    }
}
