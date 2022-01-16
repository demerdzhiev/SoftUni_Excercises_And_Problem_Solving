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
            int elementsToEnqueue = elements[0];
            int elementsToDequeue = elements[1];
            int elementToPeek = elements[2];

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> myQueue = new Queue<int>(numbers);

            for (int i = 0; i < elementsToDequeue; i++)
            {
                myQueue.Dequeue();
            }
            if (myQueue.Count == 0)
            {
                Console.WriteLine(myQueue.Count);
            }
            if (myQueue.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (myQueue.Count > 0)
                {
                    Console.WriteLine(myQueue.Min());
                }

            }
        }
    }
}
