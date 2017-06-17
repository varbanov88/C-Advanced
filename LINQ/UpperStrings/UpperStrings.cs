using System;
using System.Linq;

namespace UpperStrings
{
    public class UpperStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split()
                               .Select(w => w.ToUpper())
                               .ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
