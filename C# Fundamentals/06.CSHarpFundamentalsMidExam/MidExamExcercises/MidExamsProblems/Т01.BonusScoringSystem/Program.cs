using System;

namespace Т01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfStudents = double.Parse(Console.ReadLine());
            double countOfLectures = double.Parse(Console.ReadLine());
            double additionalBOnus = double.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAttendance = 0;

            for (double i = 0; i < countOfStudents; i++)
            {
                double attendance = double.Parse(Console.ReadLine());
                if (attendance > maxAttendance)
                {
                    maxAttendance = attendance;
                }
                double bonus = attendance / countOfLectures * (5 + additionalBOnus);
                if (bonus > maxBonus)
                {
                    maxBonus = Math.Ceiling(bonus);
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }


    }
}
