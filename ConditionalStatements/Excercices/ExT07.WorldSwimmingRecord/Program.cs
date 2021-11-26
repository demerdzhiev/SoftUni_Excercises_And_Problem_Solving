using System;

namespace ExT07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double late = Math.Floor(distance / 15) * 12.5;
            double result = (distance * time) + late;
            double difference = result - record;

            if (result < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }

        }
    }
}
