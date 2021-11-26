using System;

namespace LabT06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int etages = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            
            for (int floor = etages; floor >= 1; floor--)
            {
                if (floor == etages)
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"L{floor}{room} "); 
                    }
                    Console.WriteLine();
                }
                else if (floor % 2 == 0)
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"O{floor}{room} "); 
                    }
                    Console.WriteLine();
                }
                else 
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"A{floor}{room} ");   
                    }
                    Console.WriteLine();
                }
                    
                
            }
        }
    }
}
