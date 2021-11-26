using System;

namespace LabT04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;

            for (int i = a; i <= b; i++)
            {
                for (int n = a; n <= b; n++)
                {
                    combination++;

                        if (i + n == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {n} = {magicNumber})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
        }
    }
}
