using System.Collections.Generic;

namespace ExcellentStudents
{
    public class Student
    {
        public Student()
        {
            Grades = new List<int>();
        }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public List<int> Grades { get; set; }
    }
}
