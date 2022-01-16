using System;

namespace T01.MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double energyOfTheGroup = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double currAmountOFEnergy = energyOfTheGroup;
            double currAmountOfWater = waterPerDayPerPerson * playersCount * daysCount;
            double currAmountOfFood = foodPerDayPerPerson * playersCount * daysCount;

            for (int i = 1; i <= daysCount; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                currAmountOFEnergy -= energyLoss;

                if (currAmountOFEnergy <= 0)
                {
                    break;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    currAmountOFEnergy = currAmountOFEnergy * 1.05;
                    currAmountOfWater -= currAmountOfWater * 0.3;
                    currAmountOFEnergy = currAmountOFEnergy * 1.1;
                    currAmountOfFood -= currAmountOfFood / playersCount;
                }
                else if (i % 2 == 0)
                {
                    currAmountOFEnergy = currAmountOFEnergy * 1.05;
                    currAmountOfWater -= currAmountOfWater * 0.3;
                }
                else if (i % 3 == 0)
                {
                    currAmountOFEnergy = currAmountOFEnergy * 1.1;
                    currAmountOfFood -= currAmountOfFood / playersCount;
                }

            }
            if (currAmountOFEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {currAmountOFEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currAmountOfFood:f2} food and {currAmountOfWater:f2} water.");
            }
        }
    }
}
