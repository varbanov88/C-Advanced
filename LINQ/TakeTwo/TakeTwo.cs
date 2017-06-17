using System;
using System.Linq;

namespace TakeTwo
{
    public class TakeTwo
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .Where(n => n >= 10 && n <= 20)
                               .Distinct()
                               .Take(2)
                               .ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
