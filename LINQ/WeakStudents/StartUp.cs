using System;
using System.Collections.Generic;
using System.Linq;

namespace WeakStudents
{
    public class StartUp
    {
        public static void Main(string[] args)
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
                var poorGrades = grades.Where(g => g <= 3).ToList();

                if (poorGrades.Count >= 2)
                {
                    var student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Grades = grades
                    };

                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var st in students)
            {
                Console.WriteLine($"{st.FirstName} {st.LastName}");
            }
        }
    }
}
