using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] tokkens = command.Split().ToArray();
                string currCmd = tokkens[0];
                int currValue = int.Parse(tokkens[1]);

                if (currCmd == "Add")
                {
                    numbers.Add(currValue);
                }
                else if (currCmd == "Remove")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == currValue)
                        {
                            numbers.RemoveAt(i);
                            break;
                        }
                    }
                }
                else if (currCmd == "Replace")
                {
                    int newValue = int.Parse(tokkens[2]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == currValue)
                        {
                            numbers.RemoveAt(i);
                            numbers.Insert(i, newValue);
                            break;
                        }
                    }
                }
                else if (currCmd == "Collapse")
                {
                    numbers.RemoveAll(num => num < currValue);
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
