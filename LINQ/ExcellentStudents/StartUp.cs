using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcellentStudents
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens.First();
                var lastName = tokens[1];
                var grades = tokens.Skip(2)
                                   .Select(int.Parse)
                                   .ToList();

                var student = new Student
                {
                    FistName = firstName,
                    LastName = lastName,
                    Grades = grades
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s => s.Grades.Contains(6))
                    .ToList()
                    .ForEach(s => Console.WriteLine($"{s.FistName} {s.LastName}"));
        }
    }
}
