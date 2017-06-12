using System;
using System.Text.RegularExpressions;

namespace ExtractEmail
{
    public class ExtractEmail
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@" \b([a-z](?:_?[a-z0-9\-\.]+@[a-z\-]+\.[a-z]+([\.a-z]+)?))\b");
            var result = regex.Matches(input);

            foreach (var match in result)
            {
                Console.WriteLine(match);
            }
        }
    }
}
