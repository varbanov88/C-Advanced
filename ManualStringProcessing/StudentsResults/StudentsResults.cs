using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsResults
{
    public class StudentsResults
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var studentsData = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                var studentInfo = Console.ReadLine()
                                         .Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .ToArray();

                studentsData[studentInfo[0]] = new List<double>();
                for (int j = 1; j < studentInfo.Length; j++)
                {
                    studentsData[studentInfo[0]].Add(double.Parse(studentInfo[j]));
                }
            }

            Console.WriteLine(string.Format("{0, -10}|{1, 7}|{2, 7}|{3, 7}|{4, 7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            foreach (var kvp in studentsData)
            {
                Console.WriteLine(string.Format("{0, -10}|{1,7:f2}|{2, 7:f2}|{3, 7:f2}|{4, 7:f4}|",
                                                kvp.Key, studentsData[kvp.Key][0], studentsData[kvp.Key][1], studentsData[kvp.Key][2], kvp.Value.Average()));
            }
        }
    }
}