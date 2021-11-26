using System;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorInUSD = double.Parse(Console.ReadLine());
            double videoCardinUSD = double.Parse(Console.ReadLine());
            double RAMriceInUSD = double.Parse(Console.ReadLine());
            double RAMcount = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double processorInLV = processorInUSD * 1.57;
            double videoCardInLv = videoCardinUSD * 1.57;
            double ramInLv = RAMriceInUSD * 1.57;
            double processorAfterDisc = processorInLV - processorInLV * discount;
            double videoCartAfterDisc = videoCardInLv - videoCardInLv * discount;


            double moneyNeeded = processorAfterDisc + videoCartAfterDisc + (RAMcount * ramInLv);

            Console.WriteLine($"Money needed - {moneyNeeded:f2} leva.");
        }
    }
}
