using System;
using System.Linq;

namespace SortEvenNumbers
{
    public class SortEvenNumbers
    {
        public static void Main()
        {
            Func<string, int> func = Parser;
            var input = Console.ReadLine()
                               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(func)
                               .Where(n => n % 2 == 0)
                               .OrderBy(n => n)
                               .ToList();

            Console.WriteLine(string.Join(", ", input));
        }

        public static int Parser(string num)
        {
            return int.Parse(num);
        }
    }
}
