using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var guests = new SortedSet<string>();

            while (!input.Equals("PARTY"))
            {
                guests.Add(input);

                input = Console.ReadLine();
            }

            while (!input.Equals("END"))
            {
                guests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
