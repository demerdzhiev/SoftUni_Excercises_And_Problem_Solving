using System;

namespace ExT01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedeBook = Console.ReadLine();
            int bookCounter = 0;
            string book = Console.ReadLine();

            while (searchedeBook != book)
            {
                

                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                    break;
                }
                bookCounter++;
                book = Console.ReadLine();
            }

            if (book == searchedeBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }

        }
    }
}
