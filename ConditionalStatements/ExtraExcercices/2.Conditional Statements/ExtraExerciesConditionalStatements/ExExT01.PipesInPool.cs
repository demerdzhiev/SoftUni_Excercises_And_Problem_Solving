using System;

namespace ExtraExerciesConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = p1 * hours + p2 * hours;


            if (water <= v)
            {
                double waterPersent = water / v * 100;
                double p1Persent = p1 * hours / water * 100;
                double p2Persent = p2 * hours / water * 100;


                Console.WriteLine($"The pool is {waterPersent:F2}% full. Pipe 1: {p1Persent:F2}%. Pipe 2: {p2Persent:F2}%.");
            }
            else
            {
                double waterMore = water - v;

                Console.WriteLine($"For {hours:F2} hours the pool overflows with {waterMore:F2} liters.");
            }

        }
    }
}
