using System.Collections.Generic;

public class Student
{
    public Student()
    {
        Grades = new List<int>();
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public List<int> Grades { get; set; }
}
