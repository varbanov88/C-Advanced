using System;
using System.Text.RegularExpressions;

namespace VowelCount
{
    public class VowelCount
    {
        public static void Main()
        {
            var regex = new Regex(@"[aeiouyAEIOUY]");
            var text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
