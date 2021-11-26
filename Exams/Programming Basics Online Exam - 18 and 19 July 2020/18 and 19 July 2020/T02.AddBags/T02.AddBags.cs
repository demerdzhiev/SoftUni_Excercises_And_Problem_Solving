using System;

namespace T02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;

            double priceOver20KG = double.Parse(Console.ReadLine());
            double weightOfLuggage = double.Parse(Console.ReadLine());
            double daysToFLight = double.Parse(Console.ReadLine());
            double countOfLuggage = double.Parse(Console.ReadLine());


            if (weightOfLuggage < 10)
            {
                price = priceOver20KG * 0.2;
            }
            else if (weightOfLuggage >= 10 && weightOfLuggage <= 20)
            {
                price = priceOver20KG * 0.5;
            }
            else if (weightOfLuggage > 20)
            {
                price = priceOver20KG;
            }

            if (daysToFLight > 30)
            {
                price = price * 1.1;
            }
            else if (daysToFLight >= 7 && daysToFLight <= 30)
            {
                price = price * 1.15;
            }
            else if (daysToFLight < 7)
            {
                price = price * 1.4;
            }

            double totalCost = price * countOfLuggage;

            Console.WriteLine($" The total price of bags is: {totalCost:f2} lv. ");
        }
    }
}
