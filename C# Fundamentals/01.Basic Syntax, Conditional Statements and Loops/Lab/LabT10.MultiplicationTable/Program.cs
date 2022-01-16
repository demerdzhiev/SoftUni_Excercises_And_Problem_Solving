using System;

namespace LabT10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times++;
            }
        }
    }
}
