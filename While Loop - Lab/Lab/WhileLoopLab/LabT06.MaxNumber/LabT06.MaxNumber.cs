using System;

namespace LabT06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (numberString != "Stop")
            {

                int number = int.Parse(numberString);

                if (maxNumber < number)
                {
                    maxNumber = number;
                }

                numberString = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}
