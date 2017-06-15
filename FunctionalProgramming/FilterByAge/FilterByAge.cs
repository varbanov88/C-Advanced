using System;
using System.Collections.Generic;

namespace FilterByAge
{
    public class FilterByAge
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                var data = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var ageNum = int.Parse(data[1]);

                people[name] = ageNum;
            }

            var ageCondition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var printFormat = Console.ReadLine();

            Func<int, bool> tester = CreateTester(ageCondition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(printFormat);

            InvokePrinter(people, tester, printer);
        }

        private static void InvokePrinter(
            Dictionary<string, int> people,
            Func<int, bool> tester, 
            Action<KeyValuePair<string, int>> printer
            )
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string printFormat)
        {
            switch (printFormat)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");

                case "age":
                    return person => Console.WriteLine($"{person.Value}");

                case "name age":
                    return person =>
                    Console.WriteLine($"{person.Key} - {person.Value}");

                default: return null;
            }
        }

            public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default:
                    return null;
            }
        }
    }
}
