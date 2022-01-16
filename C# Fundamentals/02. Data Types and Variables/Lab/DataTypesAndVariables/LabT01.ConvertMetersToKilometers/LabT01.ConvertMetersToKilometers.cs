using System;

namespace LabT01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal kilometers = miles / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
