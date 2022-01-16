using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources))
                {
                    items[resources] = 0;

                }
                items[resources] += quantity;
                resources = Console.ReadLine();
            }
            foreach (var curResource in items)
            {
                Console.WriteLine($"{curResource.Key} -> {curResource.Value}");
            }
        }
    }
}
