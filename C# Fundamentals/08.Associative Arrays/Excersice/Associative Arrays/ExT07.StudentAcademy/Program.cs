using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
          
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {

                    students.Add(studentName, new List<double>());

                }

                students[studentName].Add(studentGrade);

            }

            foreach (var eachStudent in students.OrderByDescending(x => x.Value.Average()))
            {

                if (eachStudent.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{eachStudent.Key} -> {eachStudent.Value.Average():f2}");
                }
            }
        }
    }
    
}
