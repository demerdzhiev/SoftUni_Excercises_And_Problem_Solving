using System;

namespace ЛабТ05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string income = Console.ReadLine();
            double totalAmount = 0;

            while (income != "NoMoreMoney")
            {
                double sum = double.Parse(income);
 
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                totalAmount += sum;

                Console.WriteLine($"Increase: {sum:f2}");

                income = Console.ReadLine();
            }



            Console.WriteLine($"Total: {totalAmount:f2}");
        }
    }
}
