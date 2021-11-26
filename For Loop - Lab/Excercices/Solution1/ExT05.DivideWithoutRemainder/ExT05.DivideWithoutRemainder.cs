using System;

namespace ExT05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }


            double percentConverter1 = 1.0 * p1 / n * 100;
            double percentConverter2 = 1.0 * p2 / n * 100;
            double percentConverter3 = 1.0 * p3 / n * 100;

            Console.WriteLine($"{percentConverter1:f2}%");
            Console.WriteLine($"{percentConverter2:f2}%");
            Console.WriteLine($"{percentConverter3:f2}%");
        }
    }
}
