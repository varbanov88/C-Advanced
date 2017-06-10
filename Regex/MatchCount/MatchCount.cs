using System;
using System.Text.RegularExpressions;

namespace MatchCount
{
    public class MatchCount
    {
        public static void Main()
        {
            var regex = new Regex(Console.ReadLine());
            var text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}
