using System;

namespace ExExT04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            double taxiPriceDay =0.79;
            double taxiPriceNight = 0.90;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            double sumTaxiDay = 0.70 + taxiPriceDay * km;
            double sumTaxiNight = 0.70 + taxiPriceNight * km;
            double sumBus = busPrice * km;
            double sumTrain = trainPrice * km;

            if (partOfTheDay == "day" && km <=19)
            {
                Console.WriteLine($"{(sumTaxiDay):f2}");
            }
            else if (partOfTheDay == "night" && km < 20)
            {
                Console.WriteLine($"{(sumTaxiNight):f2}");
            }
            else if (km >= 100)
            {
                Console.WriteLine($"{(sumTrain):f2}");
            }   
            else if (km >= 20)
            {
                Console.WriteLine($"{(sumBus):f2}");
            }
           
        }
    }
}
