using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] tokkens = input.Split(" ");
                string command = tokkens[0];
                string item = tokkens[1];


                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string newGrocerie = tokkens[2];
                    int index = groceries.IndexOf(item);
                    if (groceries.Contains(item))
                    {
                        groceries.Insert(index, newGrocerie);
                        groceries.Remove(item);
                    }

                }
                else if (command == "Rearrange")
                {

                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
