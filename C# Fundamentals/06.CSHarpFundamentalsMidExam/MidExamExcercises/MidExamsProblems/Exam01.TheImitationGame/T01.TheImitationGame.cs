using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] tokens = command.Split("|");
                switch (tokens[0])
                {
                    case "Move":
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            message.Add(message[0]);
                            message.RemoveAt(int.Parse(message[0]));
                        }
                        break;
                    case "Insert":

                        break;
                    case "ChangeAll":

                        break;
                }



                command = Console.ReadLine();

            }
        }
    }
}
