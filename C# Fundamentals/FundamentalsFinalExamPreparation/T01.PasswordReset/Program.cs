using System;
using System.Collections.Generic;
using System.Text;

namespace T01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder newRawPassword = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Done")
                {
                    break;
                }

                if (command[0] == "TakeOdd")
                {

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newRawPassword.Append(password[i]);
                    }
                    password = newRawPassword.ToString();
                    Console.WriteLine(password);
                }
                else if (command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int length = int.Parse(command[2]);

                    password = password.Remove(index, length); 
                    Console.WriteLine(password);
                }
                else if (command[0] == "Substitute")
                {
                    if (password.Contains(command[1]))
                    {
                        password = password.Replace(command[1], command[2]);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
