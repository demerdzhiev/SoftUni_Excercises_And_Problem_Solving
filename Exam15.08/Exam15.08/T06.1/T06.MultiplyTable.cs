using System;

namespace T06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int left = number;
            int a = 0;
            int b = 0;
            int c = 0;

            int r = left % 10;
            a = r;
            left = left / 10;
            r = left % 10;
            b = r;
            left = left / 10;
            r = left % 10;
            c = r;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int k = 1; k <= c; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }

        }
    }
}
        
