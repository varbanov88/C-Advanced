using System;
using System.Linq;

namespace MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split()
                               .Select(double.Parse)
                               .ToList();

            var result = input.Where(n => n % 2 == 0).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No match");
            }

            else
            {
                Console.WriteLine("{0:f2}", result.Min());
            }
        }
    }
}
