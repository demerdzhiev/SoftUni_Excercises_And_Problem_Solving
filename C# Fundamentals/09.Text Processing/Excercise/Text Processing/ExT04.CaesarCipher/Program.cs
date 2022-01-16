using System;

namespace ExT04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedString = string.Empty;
            foreach (char currChar in input)
            {
                int currPosition = currChar;
                currPosition += 3;
                encryptedString += (char)currPosition;
            }
            Console.WriteLine(encryptedString);
        }
    }
}
