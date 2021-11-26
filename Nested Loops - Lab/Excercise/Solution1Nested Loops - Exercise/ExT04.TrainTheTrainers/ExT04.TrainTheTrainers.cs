using System;

namespace ExT04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string subject = Console.ReadLine();
            double totalGradeCounter = 0;
            int sumOfGrades = 0;

            while (subject != "Finish")
            {
                double gradeCounter = 0;

                for (int i = 0; i < judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeCounter += grade;
                    sumOfGrades++;
                }

                totalGradeCounter += gradeCounter;
                Console.WriteLine($"{subject} - {gradeCounter / judges:f2}.");
                subject = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalGradeCounter / sumOfGrades:f2}.");
        }
    }
}
