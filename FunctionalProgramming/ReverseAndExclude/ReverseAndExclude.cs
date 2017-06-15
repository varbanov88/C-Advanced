using System;
using System.Linq;

namespace ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToList();

            var divider = int.Parse(Console.ReadLine());
            Func<int, bool> findNums = n => n % divider != 0;

            var result = numbers.Where(findNums).Reverse().ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
