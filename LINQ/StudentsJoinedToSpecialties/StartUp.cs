using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsJoinedToSpecialties
{


    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();

            while (input != "Students:")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var specialityName = tokens[0] + " " + tokens[1];
                var number = int.Parse(tokens.Last());
                var speciality = new StudentSpecialty
                {
                    FacultyNumber = number,
                    SpecialtyName = specialityName
                };

                specialties.Add(speciality);

                input = Console.ReadLine();
            }

            var studentInput = Console.ReadLine();

            while (studentInput != "END")
            {
                var tokens = studentInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var number = int.Parse(tokens.First());
                var name = tokens[1] + " " + tokens[2];

                var student = new Student
                {
                    Name = name,
                    FacultyNumber = number
                };

                students.Add(student);

                studentInput = Console.ReadLine();
            }

            specialties.Join(students, sp => sp.FacultyNumber, st => st.FacultyNumber, (sp, st) => new
            {
                Name = st.Name,
                FacNum = st.FacultyNumber,
                Speciality = sp.SpecialtyName
            })
            .OrderBy(res => res.Name)
            .ToList()
            .ForEach(res => Console.WriteLine($"{res.Name} {res.FacNum} {res.Speciality}"));
        }
    }
}
