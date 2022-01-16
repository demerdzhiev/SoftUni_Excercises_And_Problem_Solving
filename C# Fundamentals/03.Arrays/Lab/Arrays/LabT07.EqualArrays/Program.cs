using System;
using System.Linq;

namespace LabT07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumber = arr1[i];
                sum += currentNumber;
                
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
