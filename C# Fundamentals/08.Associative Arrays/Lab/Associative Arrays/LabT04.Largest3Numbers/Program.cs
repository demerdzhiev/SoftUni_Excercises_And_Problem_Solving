using System;
using System.Collections.Generic;
using System.Linq;

namespace LabT04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .OrderByDescending(x => x)
               .Take(3)
               .ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
