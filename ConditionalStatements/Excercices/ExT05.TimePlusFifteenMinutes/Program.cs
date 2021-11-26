using System;

namespace ExT05.TimePlusFifteenMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PLUS_TIME = 15;
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += PLUS_TIME;
            if (minutes >=60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
