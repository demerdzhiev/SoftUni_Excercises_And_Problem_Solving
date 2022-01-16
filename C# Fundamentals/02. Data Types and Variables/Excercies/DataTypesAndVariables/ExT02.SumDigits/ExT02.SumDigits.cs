using System;

namespace ExT02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int sum = 0;
            do
            {
                int finalDigit = n % 10;
                n /= 10;
                sum += finalDigit;

            } while (n != 0);

            Console.WriteLine(sum);
        }
    }
}
