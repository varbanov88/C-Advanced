using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByFirstAndLastName
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
                var lastName = tokens.Last();

                var toAdd = string.Compare(firstName, lastName);

                if (toAdd == -1)
                {
                    var student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
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
