using System;
using System.Linq;

namespace KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            Console.ReadLine()
                   .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                   .ToList()
                   .ForEach(n => Console.WriteLine($"Sir {n}"));
        }
    }
}
