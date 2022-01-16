using System;
using System.Collections.Generic;

namespace T01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>();

            foreach (var currChar in input)
            {
                myStack.Push(currChar);
            }

            while (myStack.Count != 0)
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
