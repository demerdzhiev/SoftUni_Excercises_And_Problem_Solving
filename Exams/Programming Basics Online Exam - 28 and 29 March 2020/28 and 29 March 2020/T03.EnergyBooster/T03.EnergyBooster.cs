using System;

namespace T03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderedSets = int.Parse(Console.ReadLine());

            double price = 0;
            double priceTotal = 0;
            double finalPrice = 0;

            switch (fruit)
            {
               case "Watermelon":
                    if (size == "small")
                    {
                        price = 56;
                    }
                    else if (size == "big")
                    {
                        price = 28.70;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        price = 36.66;
                    }
                    else if (size == "big")
                    {
                        price = 19.60;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        price = 42.10;
                    }
                    else if (size == "big")
                    {
                        price = 24.80;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        price = 20;
                    }
                    else if (size == "big")
                    {
                        price = 15.20;
                    }
                    break;

            }

            if (size == "small")
            {
                priceTotal = price * 2 * orderedSets;
            }
            else
            {
                priceTotal = price * 5 * orderedSets;
            }

            if (priceTotal >= 400 && priceTotal <= 1000)
            {
                finalPrice = priceTotal * 0.85;
            }
            else if (priceTotal > 1000)
            {
                finalPrice = priceTotal * 0.5;
            }
            else
            {
                finalPrice = priceTotal;
            }

            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
