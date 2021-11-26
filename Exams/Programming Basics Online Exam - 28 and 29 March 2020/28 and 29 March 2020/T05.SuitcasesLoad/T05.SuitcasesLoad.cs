using System;

namespace T05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());

            double suitcaseCounter = 0;


            while (volume >= 0)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
                    break;
                }

                suitcaseCounter++;

                double suitcaseVolume = double.Parse(input);

                if (suitcaseCounter % 3 == 0)
                {
                    suitcaseVolume *= 1.1;
                }

                volume -= suitcaseVolume;
            }

            if (volume < 0)
            {
                suitcaseCounter--;
                Console.WriteLine("No more space!");
                Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
            }
        }
    }
}
