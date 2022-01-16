using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] ordersInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(ordersInput);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0 && totalFood >= 0)
            {
                int currentOrder = orders.Peek();

                if (totalFood - currentOrder < 0)
                {
                    break;
                }

                totalFood -= currentOrder;
                orders.Dequeue();
            }

            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
