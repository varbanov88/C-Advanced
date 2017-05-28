using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('-');
            var phonebook = new Dictionary<string, string>();

            while (!input[0].Equals("search"))
            {
                phonebook[input[0]] = input[1];
                input = Console.ReadLine().Split('-');
            }
            var name = Console.ReadLine();

            while (!name.Equals("stop"))
            {
                if (!phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }

                else
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }

                name = Console.ReadLine();
            }

        }
    }
}
