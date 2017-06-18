using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByGroup
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
                var group = int.Parse(tokens.Last());

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Group = group
                };

                result.Add(student);

                input = Console.ReadLine();
            }

            var output = result.Where(s => s.Group == 2)
                                 .OrderBy(s => s.FirstName)
                                 .ToList();

            foreach (var student in output)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

        }
    }
}
