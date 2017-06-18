using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupByGroup
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var people = new List<Person>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0] + " " + tokens[1];
                var group = int.Parse(tokens.Last());

                var person = new Person
                {
                    Name = name,
                    Group = group
                };

                people.Add(person);

                input = Console.ReadLine();
            }

            var groups = people.GroupBy(person => person.Group, person => person.Name);

            foreach (var group in groups.OrderBy(g => g.Key))
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group)}");
            }
        }
    }
}
