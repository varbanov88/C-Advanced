using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterStudentsByEmailDomain
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = tokens.First();
                var lastName = tokens[1];
                var email = tokens.Last();

                if (email.Contains("@gmail.com"))
                {
                    var student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email
                    };

                    result.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var student in result)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
