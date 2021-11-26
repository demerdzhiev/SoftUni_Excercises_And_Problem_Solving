using System;

namespace ExT02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            double extraBonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 1000)
            {
                bonusPoints = points * 0.1;
            }
            else if (points > 100) 
            {
                bonusPoints = points * 0.2;
            }
            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
