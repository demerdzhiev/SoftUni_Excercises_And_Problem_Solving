using System;

namespace T06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            int wins = 0;
            int loses = 0;
            
            double totalPrices = 0;


            for (int i = 0; i < tournamentDays; i++)
            {
                string sport = Console.ReadLine();
                double pricesPerDay = 0;
                int winsPerDay = 0;
                int losesPerDay = 0;

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        winsPerDay++;
                        wins += winsPerDay;
                        pricesPerDay += 20;
                    }
                    else if (result == "lose")
                    {
                        losesPerDay++;
                        loses += losesPerDay;
                    }
                    sport = Console.ReadLine();
                }

                if (winsPerDay > losesPerDay)
                {
                    pricesPerDay *= 1.1;
                    totalPrices += pricesPerDay;
                }
                else
                {
                    totalPrices += pricesPerDay;
                }
            }
            if (wins > loses)
            {
                totalPrices *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalPrices:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalPrices:f2}");
            }
        }
    }
}
