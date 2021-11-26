using System;

namespace ExExT02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int normPerYear = 30000;
            int workingDays = 365 - daysOff;
            int playInWorkingDay = 63;
            int playInDayOff = 127;
            int playInDayOffPerYear = playInDayOff * daysOff;
            int playInWokringDaysPerYear = playInWorkingDay * workingDays;
            int totalPlayForTheYear = playInWokringDaysPerYear + playInDayOffPerYear;
           
            
            
            if (totalPlayForTheYear > normPerYear)
            {
                Console.WriteLine("Tom will run away");
                int differenceInTime = totalPlayForTheYear - normPerYear;
                int hours = differenceInTime / 60;
                int minutes = differenceInTime % 60;
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }

            else if (totalPlayForTheYear < normPerYear)
            {
                Console.WriteLine("Tom sleeps well");
                int differenceInTime = normPerYear - totalPlayForTheYear;
                int hours = differenceInTime / 60;
                int minutes = differenceInTime % 60;
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }


        }
    }
}
