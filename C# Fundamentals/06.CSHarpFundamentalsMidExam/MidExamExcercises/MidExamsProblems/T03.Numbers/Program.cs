using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //double averageNumber = numbers.Average();
            //List<int> newNumbers = new List<int>();

            //for (int i = 1; i < numbers.Count + 1; i++)
            //{
            //    if (numbers[i] > averageNumber)
            //    {
            //        newNumbers.Add(numbers[i]);
            //    }
            //    if (newNumbers.Count > 4)
            //    {
            //        break;
            //    }
            //}
            //if (newNumbers.Count <= 0)
            //{
            //    Console.WriteLine("No");
            //    return;
            //}


            //newNumbers.OrderByDescending(x => x).Where(num => num > averageNumber);
            //Console.WriteLine(string.Join(" ", newNumbers));


            List<int> numbers = Console
                      .ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            List<int> newNumbers = new List<int>();

            double averageSum = numbers.Average();

            newNumbers = numbers
              .OrderByDescending(x => x)
              .Where(num => num > averageSum)
              .Take(5)
              .ToList();

            if (newNumbers.Count <= 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
