using System;
using System.Linq;

namespace OutEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 10 elements in the array:");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
