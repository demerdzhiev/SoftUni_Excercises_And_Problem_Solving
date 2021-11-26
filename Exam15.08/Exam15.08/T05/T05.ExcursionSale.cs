using System;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEA = 680;
            const int MOUNTAIN = 499;
            int seaVacantions = int.Parse(Console.ReadLine());
            int mountainVacantions = int.Parse(Console.ReadLine());
            int totalVacantions = seaVacantions + mountainVacantions;
            double profit = 0;
            

            string input = Console.ReadLine();

            while (input != "Stop")
            {

                if (input == "sea" && seaVacantions > 0)
                {
                    seaVacantions--;
                    totalVacantions--;
                    profit += SEA;
                }
                else if (input == "mountain" && mountainVacantions > 0)
                {
                    mountainVacantions--;
                    totalVacantions--;
                    profit += MOUNTAIN;
                }

                input = Console.ReadLine();
               
                if (totalVacantions == 0)
                {
                    break;
                }
            }

            if (input == "Stop")
            {
                Console.WriteLine($"Profit: {profit} leva.");
                return;
            }

            Console.WriteLine("Good job! Everything is sold.");
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
