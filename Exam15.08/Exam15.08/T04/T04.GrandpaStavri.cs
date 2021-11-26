using System;

namespace T04
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalRakia = 0;
            double totalDegree = 0;
           

            for (int i = 0; i < days; i++)
            {
                double rakiaPerDay = double.Parse(Console.ReadLine());
                totalRakia += rakiaPerDay;
                double degreePerDay = double.Parse(Console.ReadLine());
                totalDegree += degreePerDay * rakiaPerDay;
            }

            double averageDegree = totalDegree / totalRakia;

            Console.WriteLine($"Liter: {totalRakia:f2}");
            Console.WriteLine($"Degrees: {averageDegree:f2}");

            if (averageDegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
                return;
            }
            else if (averageDegree >= 38 && averageDegree <= 42)
            {
                Console.WriteLine("Super!");
                return;
            }
            else if (averageDegree > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
                return;
            }

        }
    }
}
