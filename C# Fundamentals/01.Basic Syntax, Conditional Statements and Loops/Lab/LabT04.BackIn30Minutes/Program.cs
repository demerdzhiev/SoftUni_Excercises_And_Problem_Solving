using System;

namespace LabT04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());

            int minutes = input + 30;

            if (minutes > 59)
            {
                hour += 1;
                minutes -= 60;
            }

            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minutes:d2}");


        }
    }
}
