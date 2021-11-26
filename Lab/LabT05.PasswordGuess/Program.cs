using System;

namespace T04._Number100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordGuess = (Console.ReadLine());

            if (passwordGuess == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }

    }

}
