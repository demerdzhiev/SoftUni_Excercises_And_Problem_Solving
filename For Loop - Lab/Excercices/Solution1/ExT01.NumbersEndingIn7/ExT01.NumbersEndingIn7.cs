using System;

namespace ExT01.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int iterator = 7; iterator <= 1000; iterator++)
            {
                if (iterator % 10 == 7)
                {
                    Console.WriteLine(iterator);
                }
            }
        }
    }
}
