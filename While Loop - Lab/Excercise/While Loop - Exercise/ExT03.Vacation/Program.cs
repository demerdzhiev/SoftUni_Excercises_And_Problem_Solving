using System;

namespace ExT03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoneyNeed = double.Parse(Console.ReadLine());
            double currMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            
            while (spendCounter != 5)
            {
                string input = Console.ReadLine(); 
                double money = double.Parse(Console.ReadLine());
                days++;
                if (input == "save")
                {
                    currMoney += money;
                    spendCounter = 0;
                }
                else if (input == "spend")
                {
                    spendCounter++;
                    if (money > currMoney)
                    {
                        currMoney = 0;
                    }
                    else
                    {
                        currMoney -= money;
                    }
                }

                if (currMoney >= vacationMoneyNeed)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
