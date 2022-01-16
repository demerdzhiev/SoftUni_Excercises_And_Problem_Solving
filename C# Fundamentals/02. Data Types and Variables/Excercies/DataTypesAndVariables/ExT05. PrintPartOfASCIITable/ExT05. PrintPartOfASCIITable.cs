using System;

namespace ExT05._PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRange = int.Parse(Console.ReadLine());
            int secondRange = int.Parse(Console.ReadLine());

            for (int i = firstRange; i <= secondRange; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
