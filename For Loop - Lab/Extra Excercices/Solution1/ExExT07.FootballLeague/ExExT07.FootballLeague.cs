using System;

namespace ExExT07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfStadium = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            double sectorAPercent = 1.0 * sectorA / numberOfFans * 100;
            double sectorBPercent = 1.0 * sectorB / numberOfFans * 100;
            double sectorVPercent = 1.0 * sectorV / numberOfFans * 100;
            double sectorGPercent = 1.0 * sectorG / numberOfFans * 100;
            double totalFans = 1.0 * sectorA + sectorB + sectorV + sectorG;
            double numberOfFansPercent = 1.0 * totalFans / capacityOfStadium * 100;

            Console.WriteLine($"{sectorAPercent:f2}%");
            Console.WriteLine($"{sectorBPercent:f2}%");
            Console.WriteLine($"{sectorVPercent:f2}%");
            Console.WriteLine($"{sectorGPercent:f2}%");
            Console.WriteLine($"{numberOfFansPercent:f2}%");
        }
    }
}
