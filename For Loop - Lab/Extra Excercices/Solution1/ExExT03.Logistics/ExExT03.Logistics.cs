using System;

namespace ExExT03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BUS_PRICE = 200;
            const double TRUCK_PRICE = 175;
            const double TRAIN_PRICE = 120;

            double cargos = double.Parse(Console.ReadLine());
            double busCargo = 0;
            double truckCargo = 0;
            double trainCargo = 0;
            double totalCargoWeight = 0;

            for (double i = 0; i < cargos; i++)
            {
                double cargosWeight = double.Parse(Console.ReadLine());

                if (cargosWeight <= 3)
                {
                    busCargo += cargosWeight;

                }
                else if (cargosWeight <= 11)
                {
                    truckCargo += cargosWeight;
                }
                else
                {
                    trainCargo += cargosWeight;
                }
                totalCargoWeight += cargosWeight;
            }
            double averagePricePerTon = (busCargo * BUS_PRICE + truckCargo * TRUCK_PRICE + trainCargo * TRAIN_PRICE) / totalCargoWeight;

            Console.WriteLine($"{averagePricePerTon:f2}");
            Console.WriteLine($"{busCargo / totalCargoWeight * 100:f2}%");
            Console.WriteLine($"{truckCargo / totalCargoWeight * 100:f2}%");
            Console.WriteLine($"{trainCargo / totalCargoWeight * 100:f2}%");
        }
    }
}
