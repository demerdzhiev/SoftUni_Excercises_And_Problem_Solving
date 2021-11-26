using System;

namespace T03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWindows = int.Parse(Console.ReadLine());
            string sizeOfWindows = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;
            double total = 0;

            if (countOfWindows < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (sizeOfWindows)
            {
                case "90X130":
                    price = 110;
                    break;
                case "100X150":
                    price = 140;
                    break;
                case "130X180":
                    price = 190;
                    break;
                case "200X300":
                    price = 250;
                    break;
            }
            if (price == 110)
            {
                if (countOfWindows >= 30 && countOfWindows < 60 )
                {
                    price *= 0.95;
                }
                else if (countOfWindows >= 60)
                {
                    price *= 0.92;
                }
            }
            else if (price == 140)
            {
                if (countOfWindows >= 40 && countOfWindows < 80)
                {
                    price *= 0.94;
                }
                else if (countOfWindows >= 80)
                {
                    price *= 0.90;
                }
            }
            else if (price == 190)
            {
                if (countOfWindows >= 20 && countOfWindows < 50)
                {
                    price *= 0.93;
                }
                else if (countOfWindows >= 50)
                {
                    price *= 0.88;
                }
            }
            else if (price == 250)
            {
                if (countOfWindows >= 25 && countOfWindows < 50)
                {
                    price *= 0.91;
                }
                else if (countOfWindows >= 50)
                {
                    price *= 0.86;
                }
            }

            total = countOfWindows * price;

            if (delivery == "With delivery")
            {
                total += 60;
            }

            if (countOfWindows > 99)
            {
                total *= 0.96;
            }

            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
