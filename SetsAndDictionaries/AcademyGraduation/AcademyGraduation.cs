using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, double[]>();

            for (int i = 0; i < studentsCount; i++)
            {
                var student = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                students.Add(student, grades);
            }

            foreach (var person in students)
            {
                var average = person.Value.Average();
                Console.WriteLine($"{person.Key} is graduated with {average}");
            }
        }
    }
}
