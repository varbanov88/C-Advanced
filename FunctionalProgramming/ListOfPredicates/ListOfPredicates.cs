using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    public class ListOfPredicates
    {
        public static void Main()
        {
            var rangeEnd = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            var result = new List<int>();
            Func<int, int, bool> filter = (n, d) => n % d == 0;


            for (int i = 1; i <= rangeEnd; i++)
            {
                var toAdd = true;

                foreach (var divider in dividers)
                {
                    
                    if (!filter(i, divider))
                    {
                        toAdd = false;
                        break;
                    }
                }
                if (toAdd)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
