using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToArray();


            var dictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }

                else
                {
                    dictionary[number]++;
                }
            }
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
