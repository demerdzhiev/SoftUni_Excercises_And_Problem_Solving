using System;

namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForFirstDear = double.Parse(Console.ReadLine());
            double foodForSecondDear = double.Parse(Console.ReadLine());
            double foodForThirdDear = double.Parse(Console.ReadLine());

            double foodPerDay = foodForFirstDear + foodForSecondDear + foodForThirdDear;
            double totalFoodNeeded = foodPerDay * days;

            if (food >= totalFoodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food - totalFoodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - food)} more kilos of food are needed.");
            }
        }
    }
}
