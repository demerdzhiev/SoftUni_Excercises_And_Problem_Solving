using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT07.AppendArrays
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numList = new List<int>();
            foreach (var str in numbersAsStrings)
            {
                numList.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numList));
        }

    }
}
