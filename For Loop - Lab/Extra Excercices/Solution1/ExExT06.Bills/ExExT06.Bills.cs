using System;

namespace ExExT06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            const double WATER = 20;
            const double INTERNET = 15;

            double months = double.Parse(Console.ReadLine());

            double electricityTotal = 0;

            for (double i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityTotal += electricity;
            }

            double waterTOtal = WATER * months;
            double internetTotal = INTERNET * months;
            double other = (electricityTotal + waterTOtal + internetTotal) * 1.2;

            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTOtal:f2} lv");
            Console.WriteLine($"Internet: {internetTotal:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {(electricityTotal + waterTOtal + internetTotal + other) / months:f2} lv");
        }
    }
}
