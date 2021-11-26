using System;

namespace T04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double foodTotal = double.Parse(Console.ReadLine());

            double eatenByDog = 0;
            double eatenByCat = 0;
            double buicits = 0;

            for (double i = 1; i <= days; i++)
            {
                double eatenByDogPerDay = double.Parse(Console.ReadLine());
                double eatenByCatPerDay = double.Parse(Console.ReadLine());


                if (i % 3 == 0)
                {
                    double buiscitsPerDay = (eatenByDogPerDay + eatenByCatPerDay) * 0.1;
                    buicits += buiscitsPerDay;
                }

                eatenByDog += eatenByDogPerDay;
                eatenByCat += eatenByCatPerDay;
            }

            double totalEaten = eatenByCat + eatenByDog;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(buicits)}gr.");
            Console.WriteLine($"{totalEaten / foodTotal * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenByDog / totalEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenByCat / totalEaten * 100:f2}% eaten from the cat.");

        }
    }
}
