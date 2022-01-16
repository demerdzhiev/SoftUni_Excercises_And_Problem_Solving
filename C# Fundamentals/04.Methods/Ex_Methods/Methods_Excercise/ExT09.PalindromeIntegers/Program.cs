using System;

namespace ExT09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isIntegerPalindrome = ReturnsIsNumberPalindrome(input);
                if (isIntegerPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool ReturnsIsNumberPalindrome(string input)
        {
            int number = int.Parse(input);
            bool result = false;
            if (number >= 0 && number <= 9)
            {
                result = true;
            }
            else
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] == input[input.Length - 1])
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
