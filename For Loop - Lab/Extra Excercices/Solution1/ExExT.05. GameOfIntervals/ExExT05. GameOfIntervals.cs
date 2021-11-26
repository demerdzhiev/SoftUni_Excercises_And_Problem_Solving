using System;

namespace ExExT._05._GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = double.Parse(Console.ReadLine());
            double toNine = 0;
            double toNineteen = 0;
            double toTwentyNine = 0;
            double toThirtyNine = 0;
            double toFifty = 0;
            double invalidNumbers = 0;
            double result = 0;

            for (int i = 0; i < moves; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                
                if (numbers >= 0 && numbers <= 9)
                {
                    result += numbers * 0.2;
                    toNine++;
                }
                else if (numbers >= 10 && numbers <= 19)
                {
                    result += numbers * 0.3;
                    toNineteen++;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    result += numbers * 0.4;
                    toTwentyNine++;
                }
                else if (numbers >= 30 && numbers <= 39)    
                {
                    result += 50;
                    toThirtyNine++;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    result += 100;
                    toFifty++;
                }
                else 
                {
                    result /= 2;
                    invalidNumbers++;
                }

            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {toNine / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {toNineteen / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {toTwentyNine / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {toThirtyNine / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {toFifty / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers / moves * 100:f2}%");


        }
    }
}
