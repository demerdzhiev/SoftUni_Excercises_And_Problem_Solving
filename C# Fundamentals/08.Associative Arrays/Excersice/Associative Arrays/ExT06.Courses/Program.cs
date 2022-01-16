using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split(" : ");
                var courseName = tokens[0];
                var studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
                
                input = Console.ReadLine();
            }
            courses = courses.OrderByDescending(key => key.Value.Count).ToDictionary(x => x.Key, u => u.Value);
            foreach (var course in courses)
            {
                course.Value.Sort();
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", course.Value));
            }
        }
    }
}
