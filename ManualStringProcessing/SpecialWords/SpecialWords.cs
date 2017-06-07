using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialWords
{
    public class SpecialWords
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine()
                                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            var text = Console.ReadLine()
                              .Split(new[] {' ', '?', '!', '-', ',', '>', '<', '[', ']', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();

            foreach (var specialWord in specialWords)
            {
                wordsCount[specialWord] = 0;
                foreach (var word in text)
                {
                    if (specialWord == word)
                    {
                        wordsCount[specialWord]++;
                    }
                }
            }

            foreach (var kvp in wordsCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
