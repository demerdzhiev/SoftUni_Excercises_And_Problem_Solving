using System;

namespace ExT06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= tabs; i++)
            {

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary. ");
                    break;
                }

                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (website == "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (website == "Reddit")
                {
                    salary -= REDDIT;
                }
                
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}


