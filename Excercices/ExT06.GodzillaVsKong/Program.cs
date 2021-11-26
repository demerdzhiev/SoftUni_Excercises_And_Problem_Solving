using System;

namespace ExT06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
           
            if (statists > 150)
            {
                costumePrice = costumePrice - costumePrice * 0.1;
            }

            double costumesTotal = costumePrice * statists;
            double movieTotal = costumesTotal + decor;

            if (movieTotal > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {movieTotal - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - movieTotal:f2} leva left.");
            }


        }
    }
}
