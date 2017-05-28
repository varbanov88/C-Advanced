using System;
using System.Collections.Generic;

namespace CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var symbols = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!symbols.ContainsKey(ch))
                {
                    symbols.Add(ch, 0);
                }
                symbols[ch]++;
            }

            foreach (var pair in symbols)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
