using System;

namespace ExExT04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double exellent = 0;
            double good = 0;
            double middle = 0;
            double fail = 0;
            double averageGrades = 0;


            for (double i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    fail++;
                }
                else if (grade <= 3.99)
                {
                    middle++;
                }
                else if (grade <= 4.99)
                {
                    good++;
                }
                else if (grade >= 5)
                {
                    exellent++;
                }

                averageGrades += grade;
            }
            Console.WriteLine($"Top students: {exellent / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middle / students * 100:f2}%");
            Console.WriteLine($"Fail: {fail / students * 100:f2}%");
            Console.WriteLine($"Average: {averageGrades / students :f2}");
        }
    }
}
