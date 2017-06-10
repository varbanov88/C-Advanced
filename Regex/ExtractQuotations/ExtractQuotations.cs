using System;
using System.Text.RegularExpressions;

namespace ExtractQuotations
{
    public class ExtractQuotations
    {
        public static void Main()
        {
            string pattern = @"('|"")(.+?)\1";
            var regex = new Regex(pattern);

            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
