using System;
using System.Collections.Generic;
using System.Linq;

namespace Т03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currCmd = command.Split(" - ").ToArray();
                string currAction = currCmd[0];
                string currItem = currCmd[1];

                if (currAction == "Add")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (currItem == items[i])
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    items.Add(currItem);
                }
                else if (currAction == "Remove")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (currItem == items[i])
                        {
                            items.RemoveAt(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (currAction == "Bonus phone")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        string[] combineItems = currItem.Split(":").ToArray();
                        string oldItem = combineItems[0];
                        string newItem = combineItems[1];

                        if (oldItem == items[i])
                        {
                            items.Insert(i + 1, newItem);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (currAction == "Last")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (currItem == items[i])
                        {
                            items.Add(currItem);
                            items.RemoveAt(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
