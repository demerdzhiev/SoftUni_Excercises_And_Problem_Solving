using System;

namespace T01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double statuesPrice = hallRent * 0.7;
            double caterringPrice = statuesPrice * 0.85;
            double soundPrice = caterringPrice * 0.5;

            Console.WriteLine($"{hallRent + statuesPrice + caterringPrice + soundPrice:f2}");
        }
    }
}
