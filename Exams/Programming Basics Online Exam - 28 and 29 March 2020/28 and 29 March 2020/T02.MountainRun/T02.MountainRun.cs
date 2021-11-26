using System;

namespace T02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distance / 50) * 30;
            double realTime = distance * timePerMeter + delay;
            double difference = Math.Abs(currentRecord - realTime);

            if (realTime < currentRecord)
            {
                Console.WriteLine($"Yes! The new record is {realTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {difference:f2} seconds slower.");
            }
        }
    }
}
