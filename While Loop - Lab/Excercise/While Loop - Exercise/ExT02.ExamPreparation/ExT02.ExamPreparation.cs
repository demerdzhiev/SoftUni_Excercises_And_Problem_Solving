using System;

namespace ExT02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            string lastProblemName = "";
            double scoreCounter = 0;
            double gradesounter = 0;
            double countBadGrades = 0;

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                scoreCounter += grade;
                gradesounter++;
                if (grade <= 4)
                {
                    countBadGrades++;
                    if (countBadGrades == badGrades)
                    {
                        break;
                    }
                }
                lastProblemName = problemName;
                problemName = Console.ReadLine();  
            }
            if (problemName == "Enough")
            {
                double averageScore = 1.0 * scoreCounter / gradesounter;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradesounter}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
            }
        }
    }
}
