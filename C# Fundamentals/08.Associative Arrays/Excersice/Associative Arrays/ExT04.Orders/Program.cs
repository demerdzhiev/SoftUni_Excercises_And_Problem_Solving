using System;
using System.Collections.Generic;

namespace ExT04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                var tokens = input.Split();
                var product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);
                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, price);
                    newOrders.Add(product, quantity);
                }
                else if (orders.ContainsKey(product))
                {
                    orders.Remove(product);
                    orders.Add(product, price);
                    newOrders[product] += quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
