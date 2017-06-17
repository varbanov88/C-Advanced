using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAndSumIntegers
{
    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split()
                               .ToArray();

            var result = new List<long>();

            foreach (var word in input)
            {
                long num = 0;
                var isNum = long.TryParse(word, out num);

                if (isNum)
                {
                    result.Add(num);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No match");
            }

            else
            {
                Console.WriteLine(result.Sum());
            }
        }
    }
}
