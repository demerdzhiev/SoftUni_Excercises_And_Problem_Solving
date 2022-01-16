using System;
using System.Collections.Generic;
using System.Linq;

namespace LabT06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        MyList.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        MyList.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        MyList.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToAddAt = int.Parse(tokens[2]);
                        MyList.Insert(indexToAddAt, numberToInsert);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", MyList));

        }
    }
}
