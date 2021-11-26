using System;

namespace T06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string movie = Console.ReadLine();


            while (movie != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                double numOfTickets = 0;

                while (numOfTickets < capacity)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }

                    numOfTickets++;
                }

                totalTickets += numOfTickets;

                Console.WriteLine($"{movie} - {numOfTickets / capacity * 100:f2}% full.");

                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");

            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
