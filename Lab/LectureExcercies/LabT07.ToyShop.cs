using System;

namespace LectureExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.6;
            double dollsPrice = 3;
            double bearsPrice = 4.1;
            double minionsPrice = 8.2;
            double trucksPrice = 2;
            double price = (puzzle * puzzlePrice) + (dolls * dollsPrice) + (bears * bearsPrice) + (minions * minionsPrice) + (trucks * trucksPrice);
            double toys = puzzle + dolls + bears + minions + trucks;

            if (toys >= 50)
            {
                price = price - (price * 0.25);
            }

            price = price - (price * 0.1);

            if (price >= tripPrice)
            {
                double enoughMoney = price - tripPrice;
                Console.WriteLine($"Yes! {(enoughMoney):f2} lv left.");
            }
            else
            {
                double moneyNeeded = tripPrice - price;
                Console.WriteLine($"Not enough money! {(moneyNeeded):f2} lv needed.");

            }

        }
    }
}
