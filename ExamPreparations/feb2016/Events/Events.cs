using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Events
{
    public class Events
    {
        public static void Main()
        {
            var eventsCount = int.Parse(Console.ReadLine());
            string input;
            var events = new Dictionary<string, Dictionary<string, List<string>>>();

            var validPattern = new Regex(@"^#([A-Za-z]+):\s*@([A-z]+)\s*((?:[0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9])$");

            for (int i = 0; i < eventsCount; i++)
            {
                input = Console.ReadLine();
                var match = validPattern.Match(input);

                if (match.Success)
                {
                    var person = match.Groups[1].Value;
                    var place = match.Groups[2].Value;
                    var time = match.Groups[3].Value;

                    if (!events.ContainsKey(place))
                    {
                        events[place] = new Dictionary<string, List<string>>();
                    }

                    if (!events[place].ContainsKey(person))
                    {
                        events[place][person] = new List<string>();
                    }

                    events[place][person].Add(time);
                }
            }

            var vanues = Console.ReadLine().Split(',').OrderBy(v => v).ToArray();

            foreach (var vanue in vanues)
            {
                if (events.ContainsKey(vanue))
                {
                    Console.WriteLine(vanue + ":");
                    var counter = 1;
                    foreach (var place in events[vanue].OrderBy(p => p.Key))
                    {
                        Console.WriteLine($"{counter}. {place.Key} -> {string.Join(", ", place.Value.OrderBy(t => t))}");
                        counter++;
                    }
                }
            }
        }
    }
}