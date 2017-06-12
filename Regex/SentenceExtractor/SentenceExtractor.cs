using System;
using System.Text.RegularExpressions;

namespace SentenceExtractor
{
    public class SentenceExtractor
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var regex = new Regex(".+?([.!?])");

            var matches = regex.Matches(Console.ReadLine());

            foreach (var sen in matches)
            {
                var innerRegex = new Regex($"\\b{pattern}\\b");
                var foundMatch = innerRegex.Match(sen.ToString());

                if (foundMatch.Success)
                {
                    Console.WriteLine(sen.ToString().TrimStart());
                }
            }
        }
    }
}
