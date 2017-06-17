using System;
using System.Linq;

namespace AverageOfDoubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Console.WriteLine("{0:f2}", input.Average());
        }
    }
}
