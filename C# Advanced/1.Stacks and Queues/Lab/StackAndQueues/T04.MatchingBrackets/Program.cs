using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> myStack = new Stack<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    myStack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = myStack.Pop();
                    Console.WriteLine(input.Substring(startIndex, (i - startIndex + 1)));
                }
            }

        }
    }
}
