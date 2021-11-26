using System;

namespace ExExT10.ClockPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int l = 0; l < 60; l++)
                    {
                        Console.WriteLine($"{i} : {j} : {l}");
                    }
                   
                }

            }
        }
    }
}
