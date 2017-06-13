using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var regex = new Regex("<p>(.+?)<\\/p>");
            string input = Console.ReadLine();
            var matches = regex.Matches(input);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var whiteSpaces = "[^a-z0-9]+";
                var remainder = match.Groups[1].Value;
                var replaced = Regex.Replace(remainder, whiteSpaces, " ");

                foreach (var ch in replaced)
                {
                    if (ch >= 'a' && ch <= 'm')
                    {
                        sb.Append((char)(ch + 13));
                    }

                    else if (ch >= 'n' && ch <= 'z')
                    {
                        sb.Append((char)(ch - 13));
                    }

                    else
                    {
                        sb.Append(ch);
                    }
                }
            }
            Console.WriteLine(sb);

        }
    }
}