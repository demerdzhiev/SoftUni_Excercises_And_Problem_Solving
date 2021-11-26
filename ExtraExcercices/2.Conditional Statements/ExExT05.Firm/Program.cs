using System;

namespace ExExT05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double daysAvailable = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double trainings = daysAvailable * 0.1;
            double actualWorkingDays = daysAvailable - trainings;
            double overtime = workers * daysAvailable * 2;
            double actualWorkingHours = Math.Floor((actualWorkingDays * 8) + overtime);


            if (actualWorkingHours >= hoursNeeded) 
            {
                double timeLeft = actualWorkingHours - hoursNeeded;
                Console.WriteLine($"Yes!{timeLeft} hours left.");
            }
            else if (actualWorkingHours < hoursNeeded)
            {
                double missedTime = hoursNeeded - actualWorkingHours;
                Console.WriteLine($"Not enough time!{missedTime} hours needed.");
            }
        }
    }
}
