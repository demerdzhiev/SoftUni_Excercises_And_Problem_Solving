using System;

namespace LabT08.Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalGradeScore = 0;
            int gradeCounter = 0;
            int failedCounter = 0;

            while (true)
            {
                double gradeInput = double.Parse(Console.ReadLine());

                if (gradeInput < 4)
                {
                    failedCounter++;

                    if (failedCounter > 1)
                    {
                        Console.WriteLine($"{input} has been excluded at {gradeCounter} grade");
                        break;
                    }
                }

                gradeCounter++;
                totalGradeScore += gradeInput;

                if (gradeCounter == 12)
                {
                    double averageScore = totalGradeScore / 12;
                    Console.WriteLine($"{input} graduated. Average grade: {averageScore:f2}");
                    break;
                }
            }
        }

    }

}
