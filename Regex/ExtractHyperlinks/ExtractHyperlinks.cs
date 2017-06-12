using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            // 87/100
            var input = Console.ReadLine();
            var regex = new Regex(@"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)");
            var sb = new StringBuilder();

            while (input != "END")
            {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            var matches = regex.Matches(sb.ToString());

            foreach (var match in matches)
            {
                var toPrint = regex.Match(match.ToString());
                Console.WriteLine(toPrint.Groups[2].Value);
            }
        }
    }
}
