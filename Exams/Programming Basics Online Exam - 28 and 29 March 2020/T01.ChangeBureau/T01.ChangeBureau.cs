using System;

namespace T01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {

            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double euroValue = 1.95;
            double bitcoinValue = 1168 / euroValue;
            double dollarValue = 1.76;
            double yuanValue = (dollarValue * 0.15) / euroValue;           
            double exchange = (bitcoins * bitcoinValue) + (yuan * yuanValue);
            double commissionValue = (commission / 100) * exchange;
            double exchangeAfterCommision = exchange - commissionValue;

            Console.WriteLine($"{exchangeAfterCommision:f2}");

        }
    }
}
