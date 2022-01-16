using System;

namespace LabT11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) / 3;
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
