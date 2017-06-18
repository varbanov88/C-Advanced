using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterStudentsByPhone
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
                var phone = tokens.Last();

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phone
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(
                s => s.PhoneNumber.StartsWith("02") || 
                s.PhoneNumber.StartsWith("+3592"))
                    .ToList()
                    .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
