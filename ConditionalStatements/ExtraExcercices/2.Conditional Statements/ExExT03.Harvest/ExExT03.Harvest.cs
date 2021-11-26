using System;

namespace ExExT03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double Z = double.Parse(Console.ReadLine());
            double Workers = double.Parse(Console.ReadLine());
            // YIELD
            double harvest = X * Y;
            // For Wine
            double ForWine = 0.4 * harvest;
            // Wade Wine
            double ProducedWine = ForWine / 2.5;
            if (ProducedWine < Z)
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - ProducedWine));
            else if (ProducedWine >= Z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(ProducedWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(ProducedWine - Z), Math.Ceiling((ProducedWine - Z) / Workers));
            }

        }
    }
}
