using System;

namespace LabT11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int oddCounter = 0;
            double savedMoney = 0;
            double moneyGift = 10;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyGift;
                    moneyGift += 10;

                    savedMoney--;
                }
                else
                {
                    oddCounter++;
                }
            }

            double profitFromToys = oddCounter * toyPrice;
            savedMoney += profitFromToys;

            double diff = Math.Abs(savedMoney - washingMachinePrice);

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }

        }
    }
}
