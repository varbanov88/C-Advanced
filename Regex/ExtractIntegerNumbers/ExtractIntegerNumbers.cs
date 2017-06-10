using System;
using System.Text.RegularExpressions;

namespace ExtractIntegerNumbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var regex = new Regex("\\d+");
            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
