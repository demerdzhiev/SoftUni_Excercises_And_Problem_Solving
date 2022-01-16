using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            
            while (line != "end")
            {
                string[] token = line.Split();
                string command = token[0];
                if (command == "Delete")
                {
                    int element = int.Parse(token[1]);
                    numbers.RemoveAll(el => el == element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    numbers.Insert(index, element);
                }

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
