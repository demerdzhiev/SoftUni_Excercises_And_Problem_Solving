using System;

namespace T04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalClimbers = 0;
            double musallaClibers = 0;
            double monblancClibers = 0;
            double killimanjaroClibers = 0;
            double k2Clibers = 0;
            double everestClibers = 0;

            double groups = double.Parse(Console.ReadLine());

            for (double i = 1; i <= groups; i++)
            {
                double climbers = double.Parse(Console.ReadLine());

                if (climbers <= 5)
                {
                    musallaClibers += climbers;
                }
                else if (climbers >= 6 && climbers <= 12)
                {
                    monblancClibers += climbers;
                }
                else if (climbers >= 13 && climbers <= 25)
                {
                    killimanjaroClibers += +climbers;
                }
                else if (climbers >= 26 && climbers <= 40)
                {
                    k2Clibers += climbers;
                }
                else if (climbers >= 41)
                {
                    everestClibers += climbers;
                }

                totalClimbers += climbers;
            }
            Console.WriteLine($"{musallaClibers / totalClimbers * 100:f2}%");
            Console.WriteLine($"{monblancClibers / totalClimbers * 100:f2}%");
            Console.WriteLine($"{killimanjaroClibers / totalClimbers * 100:f2}%");
            Console.WriteLine($"{k2Clibers / totalClimbers * 100:f2}%");
            Console.WriteLine($"{everestClibers / totalClimbers * 100:f2}%");
            
        }
    }
}
