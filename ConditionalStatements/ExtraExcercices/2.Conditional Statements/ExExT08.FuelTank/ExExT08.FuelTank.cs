using System;

namespace ExExT08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine().ToLower();
            int fuelQty = int.Parse(Console.ReadLine());

            if (fuelType == "diesel")
            {
                if (fuelQty >= 25)
                {
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else if (fuelQty < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
            }
            else if (fuelType == "gasoline")
            {
                if (fuelQty >= 25)
                {
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else if (fuelQty < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
            }
            else if (fuelType == "gas")
            {
                if (fuelQty >= 25)
                {
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else if (fuelQty < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
