using System;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());


            int c = num % 10;
            num /= 10;
            int b = num % 10;
            num /= 10;
            int a = num % 10;

            int max = int.MinValue;
            int min = int.MaxValue;

            if (a > max)
            {
                max = a;
            }
            else if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            }

            if (a < min)
            {
                min = a;
            }
            else if (b < min)
            {
                min = b;
            }
            else if (c < min)
            {
                min = c;
            }

            for (int a1 = min; a1 <= max; a1++)
            {
                for (int b1 = min; b1 <= max; b1++)
                {
                    for (int c1 = min; c1 <= max; c1++)
                    {
                        Console.WriteLine($"{a1} * {b1} * {c1} = {a1 * b1 * c1};");
                    }
                }
            }
        }
    }
}