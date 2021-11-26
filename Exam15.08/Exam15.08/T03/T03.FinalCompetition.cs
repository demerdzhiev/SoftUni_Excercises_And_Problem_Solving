using System;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = Console.ReadLine();
            double reward = 0;
            double expences = 0;
            double totalPrice = 0;
            if (season == "summer")
            {
                if (location == "Bulgaria")
                {
                    reward = points * participants;
                    expences = reward * 0.05;
                    totalPrice = reward - expences;
                }

                else if (location == "Abroad")
                {
                    reward = participants * points;
                    double bonus = reward * 0.50;
                    totalPrice = (bonus + reward);
                    expences = totalPrice * 0.10;
                    totalPrice -= expences;
                }
            }
            else if (season == "winter")
            {
                if (location == "Bulgaria")
                {
                    reward = points * participants;
                    expences = reward * 0.08;
                    totalPrice = reward - expences;
                }

                else if (location == "Abroad")
                {
                    reward = participants * points;
                    double bonus = reward * 0.50;
                    totalPrice = (bonus + reward);
                    expences = totalPrice * 0.15;
                    totalPrice -= expences;
                }
            }
            double charity = totalPrice * 0.75;
            double MoneyPerDancer = (totalPrice - charity) / participants;
            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {MoneyPerDancer:F2}");

        }
    }
}
