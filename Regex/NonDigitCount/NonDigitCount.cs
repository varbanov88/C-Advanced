using System;
using System.Text.RegularExpressions;

namespace NonDigitCount
{
    public class NonDigitCount
    {
        public static void Main()
        {
            var regex = new Regex("\\D");
            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
