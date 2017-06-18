using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsEnrolledIn2014Or2015
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var grades = new List<List<string>>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var year = tokens.First();

                if (year.EndsWith("14") || year.EndsWith("15"))
                {
                    var marks = tokens.Skip(1).ToList();
                    grades.Add(marks);
                }

                input = Console.ReadLine();
            }

            foreach (var setOfGrades in grades)
            {
                Console.WriteLine(string.Join(" ", setOfGrades));
            }
        }
    }
}
