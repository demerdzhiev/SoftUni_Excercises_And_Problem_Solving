using System;
using System.Linq;

namespace ExT01.SmallestOfThreeNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = SmallestNumber(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        static int SmallestNumber(int firstNum, int secondNum, int thirdNum)
        {
            int smallestNum = Math.Min(Math.Min(firstNum, secondNum), thirdNum);
            return smallestNum;
        }

    }
}
