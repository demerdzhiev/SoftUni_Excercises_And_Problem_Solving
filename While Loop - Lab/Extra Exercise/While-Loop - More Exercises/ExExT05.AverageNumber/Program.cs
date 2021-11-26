using System;

namespace ExExT05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            double average = sum / counter;
            Console.WriteLine($"{average:f2}");
        }
    }
}
