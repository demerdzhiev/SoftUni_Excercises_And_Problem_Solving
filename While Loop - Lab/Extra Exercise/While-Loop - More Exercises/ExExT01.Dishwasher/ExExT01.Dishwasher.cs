using System;

namespace ExExT01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BOTTLE_DETERGENT = 750;
            const int DISH_DETERGENT = 5;
            const int POT_DETERGENT = 5;

            int bottles = int.Parse(Console.ReadLine());

            int detergentTotal = bottles * BOTTLE_DETERGENT;
            int cleanDishes = 0;
            int cleanPots = 0;

            while (detergentTotal <= 0)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {

                }
            }
        }

    }
}
