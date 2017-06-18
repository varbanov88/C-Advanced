using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByAge
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
                var age = int.Parse(tokens.Last());

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                result.Add(student);

                input = Console.ReadLine();
            }

            result.Where(s => s.Age >= 18 && s.Age <= 24)
                  .ToList()
                  .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} {s.Age}"));
        }
    }
}
