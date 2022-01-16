using System;

namespace ExT02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");

            foreach (string elementsTwo in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string ellementOne = arrOne[i];
                    if (elementsTwo == ellementOne)
                    {
                        Console.Write(ellementOne + " ");
                        break;
                    }
                }
            }
        }
    }
}
