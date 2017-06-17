using System;
using System.Linq;

namespace BoundedNumbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var bounds = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            var lowBound = Math.Min(bounds.First(), bounds.Last());
            var highBound = Math.Max(bounds.First(), bounds.Last());

            var result = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .Where(n => n >= lowBound && n <= highBound)
                                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
