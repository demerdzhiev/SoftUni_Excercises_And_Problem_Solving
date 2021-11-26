using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    class zadacha6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int f4 = n % 10;
            int f3 = (n / 10) % 10;
            int f2 = (n / 100) % 10;
            int f1 = (n / 1000) % 10;

            int h4 = m % 10;
            int h3 = (m / 10) % 10;
            int h2 = (m / 100) % 10;
            int h1 = (m / 1000) % 10;

            for (int i = f1; i <= h1; i++)
            {
                for (int j = f2; j <= h2; j++)
                {
                    for (int l = f3; l <= h3; l++)
                    {
                        for (int w = f4; w <= h4; w++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && l % 2 != 0 && w % 2 != 0)
                            {
                                Console.Write("" + i + j + l + w + " ");
                            }
                        }
                    }
                }
            }

        }
    }
}