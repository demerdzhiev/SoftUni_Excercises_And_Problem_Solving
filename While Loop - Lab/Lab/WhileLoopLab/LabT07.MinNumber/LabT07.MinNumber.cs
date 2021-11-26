using System;

namespace LabT07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (numberString != "Stop")
            {

                int number = int.Parse(numberString);

                if (minNumber > number)
                {
                    minNumber = number;
                }

                numberString = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
