using System;
using System.Collections.Generic;
using System.Linq;

namespace SortStudents
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

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                result.Add(student);

                input = Console.ReadLine();
            }

            result.OrderBy(s => s.LastName)
                  .ThenByDescending(s => s.FirstName)
                  .ToList()
                  .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
