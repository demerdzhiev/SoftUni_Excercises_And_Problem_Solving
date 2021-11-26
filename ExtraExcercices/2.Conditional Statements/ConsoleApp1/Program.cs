using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());

            int P1Total = P1 * H;
            int P2Total = P2 * H;
            int total = P1Total + P2Total;
            int waterLevelInPercent = (total / V) * 100;
            int P1inPercent = (P1Total / waterLevelInPercent) * 100;
            int P2inPercent = (P2Total / waterLevelInPercent) * 100;

            if (total < V)
            {
                Console.WriteLine($"The pool is {waterLevelInPercent} full. Pipe 1: {P1inPercent}. Pipe 2: {P2inPercent}.");
            }
            else if (total > V)
            {
                Console.WriteLine($"For {H} hours the pool overflows with {total - V} liters.");
            }

        }
    }
}
