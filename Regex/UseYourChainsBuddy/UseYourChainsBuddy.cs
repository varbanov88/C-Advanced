using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            //not finished
            var pattern = new Regex("<p>(.+?)<\\/p>");
            string input = Console.ReadLine();

            var sb = new StringBuilder();

            var matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                var line = match.Groups[1].Value;
                line = Regex.Replace(line, "\\s+", " ");
                sb.Append(line).Append(" ");
            }

            var textToReplace = Regex.Replace(sb.ToString(), "[^a-z0-9]+", " ");
            var output = new StringBuilder();

            foreach (var ch in textToReplace)
            {
                if (Char.IsUpper(ch))
                {
                    output.Append(ch);
                }

                else if (ch == ' ')
                {
                    output.Append(ch);
                }

                else if (Char.IsDigit(ch))
                {
                    output.Append(ch);
                }

                else
                {
                    switch (ch)
                    {
                        case 'a': output.Append('n'); break;
                        case 'b': output.Append('o'); break;
                        case 'c': output.Append('p'); break;
                        case 'd': output.Append('q'); break;
                        case 'e': output.Append('r'); break;
                        case 'f': output.Append('s'); break;
                        case 'g': output.Append('t'); break;
                        case 'h': output.Append('u'); break;
                        case 'i': output.Append('v'); break;
                        case 'j': output.Append('w'); break;
                        case 'k': output.Append('x'); break;
                        case 'l': output.Append('y'); break;
                        case 'm': output.Append('z'); break;
                        case 'n': output.Append('a'); break;
                        case 'o': output.Append('b'); break;
                        case 'p': output.Append('c'); break;
                        case 'q': output.Append('d'); break;
                        case 'r': output.Append('e'); break;
                        case 's': output.Append('f'); break;
                        case 't': output.Append('g'); break;
                        case 'u': output.Append('h'); break;
                        case 'v': output.Append('i'); break;
                        case 'w': output.Append('j'); break;
                        case 'x': output.Append('k'); break;
                        case 'y': output.Append('l'); break;
                        case 'z': output.Append('m'); break;
                    }
                }
            }

            var result = Regex.Replace(output.ToString(), "\\s+", " ");

            Console.WriteLine(result);
        }
    }
}