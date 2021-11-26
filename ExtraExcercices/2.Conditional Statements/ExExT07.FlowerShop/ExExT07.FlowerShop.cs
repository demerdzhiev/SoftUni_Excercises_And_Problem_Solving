using System;

namespace ExExT07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double mPrice = 3.25;
            double zPrice = 4;
            double rPrice = 3.50;
            double kPrice = 8;
            double profit = m * mPrice + z * zPrice + r * rPrice + k * kPrice;
            double profitAfterTaxes = profit * 0.95;

            if (profitAfterTaxes >= giftPrice)
            {
                double moneyLeft = Math.Floor(profitAfterTaxes - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else if (giftPrice > profitAfterTaxes)
            {
                double moneyNeeded = Math.Ceiling(giftPrice - profitAfterTaxes);
                Console.WriteLine($"She will have to borrow {moneyNeeded} leva.");
            }

            
        }
    }
}
