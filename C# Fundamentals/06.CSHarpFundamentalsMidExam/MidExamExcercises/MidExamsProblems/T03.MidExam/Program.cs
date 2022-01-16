using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currCmd = command.Split(" - ").ToArray();
                string currAction = currCmd[0];
                string currModel = currCmd[1];

                if (currAction == "Add")
                {
                    if (!phones.Contains(currModel))
                    {
                        phones.Add(currModel);
                    }
                    
                }
                else if (currAction == "Remove")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (currModel == phones[i])
                        {
                            phones.RemoveAt(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (currAction == "Bonus phone")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        string[] combineItems = currModel.Split(":").ToArray();
                        string oldPhone = combineItems[0];
                        string newPhone = combineItems[1];

                        if (oldPhone == phones[i])
                        {
                            phones.Insert(i + 1, newPhone);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (currAction == "Last")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (currModel == phones[i])
                        {
                            phones.Add(currModel);
                            phones.RemoveAt(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
