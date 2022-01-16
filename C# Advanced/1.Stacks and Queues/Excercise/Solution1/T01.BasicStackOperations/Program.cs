using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int elementsToPush = elements[0];
            int elementsToPop = elements[1];
            int elementToPeek = elements[2];

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> myStack = new Stack<int>(numbers);

            for (int i = 0; i < elementsToPop; i++)
            {
                myStack.Pop();
            }
            if (myStack.Count == 0)
            {
                Console.WriteLine(myStack.Count);
            }
            if (myStack.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else 
            {
                if (myStack.Count  > 0)
                {
                    Console.WriteLine(myStack.Min());
                }
               
            }
        }
    }
}
