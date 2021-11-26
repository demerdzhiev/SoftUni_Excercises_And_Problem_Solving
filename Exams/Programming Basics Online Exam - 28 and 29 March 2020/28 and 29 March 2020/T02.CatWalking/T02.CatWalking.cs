using System;

namespace T02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk = int.Parse(Console.ReadLine());
            int countOfWalks = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int totalWalkPerDay = countOfWalks * minutesPerWalk;
            int totalCaloriesPerDay = totalWalkPerDay * 5;
            double goalCaloriesPerDay = caloriesPerDay * 0.5;

            if (totalCaloriesPerDay >= goalCaloriesPerDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesPerDay}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesPerDay}.");
            }


        }
    }
}
