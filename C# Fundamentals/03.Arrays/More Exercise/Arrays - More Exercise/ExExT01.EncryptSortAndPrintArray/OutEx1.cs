using System;

namespace ExExT01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[20];
            //int num = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    num = i * 5;
            //    Console.WriteLine(num);
            //}

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
