using System;
using System.Text;

namespace ExT05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 23
            int multiplier = int.Parse(Console.ReadLine()); // 2
            StringBuilder stringFinalProduct = new StringBuilder();
            int reminder = 0;
            if (input == "0" || multiplier == 0) // safeguard
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--) // 23 => 32
            {
                int currentDigit = int.Parse(input[i].ToString()); // 3
                int product = currentDigit * multiplier + reminder;
                int result = product % 10; // 32 / 10 => 2
                reminder = product / 10;
                stringFinalProduct.Insert(0, result);
            }
            if (reminder > 0)
            {
                stringFinalProduct.Insert(0, reminder);
            }
            Console.WriteLine(stringFinalProduct);
        }
    }
}
