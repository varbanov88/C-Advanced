using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var elms = Console.ReadLine()
                                  .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var e in elms)
                {
                    elements.Add(e);
                }
            }

            foreach (var el in elements)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
