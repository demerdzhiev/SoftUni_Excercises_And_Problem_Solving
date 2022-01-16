using System;
using System.Linq;

namespace OutEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The values store into the array are:");
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("The values store into the array in reverse are :");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
