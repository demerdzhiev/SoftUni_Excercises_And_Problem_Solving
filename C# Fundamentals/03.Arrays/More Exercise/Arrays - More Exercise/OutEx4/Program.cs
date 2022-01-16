using System;
using System.Linq;

namespace OutEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 elements in the array :");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
            
        }
    }
}
