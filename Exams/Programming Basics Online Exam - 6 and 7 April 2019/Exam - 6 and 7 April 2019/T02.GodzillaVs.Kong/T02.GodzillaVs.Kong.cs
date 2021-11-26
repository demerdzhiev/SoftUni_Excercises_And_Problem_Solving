using System;

namespace T02.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double suiteSinglePrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (statists >= 150)
            {
                suiteSinglePrice *= 0.9;
            }

            double expences = statists * suiteSinglePrice + decor;


            if (expences > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expences - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - expences:f2} leva left.");
            }
        }
    }
}
