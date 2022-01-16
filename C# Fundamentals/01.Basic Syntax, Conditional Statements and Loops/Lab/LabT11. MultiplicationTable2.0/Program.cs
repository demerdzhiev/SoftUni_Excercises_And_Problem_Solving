using System;

namespace LabT11._MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times++;
            }
            while (times <= 10);
        }
    }
}
