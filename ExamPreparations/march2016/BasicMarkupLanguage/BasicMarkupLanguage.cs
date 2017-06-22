using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicMarkupLanguage
{
    public class BasicMarkupLanguage
    {
        public static void Main()
        {
            string input;
            var words = new Queue<string>();
            var pattern = new Regex(@"\s*<\s*([a-z]+)\s+(?:value\s*=\s*""\s*(\d+)\s*""\s+)?[a-z]+\s*=\s*""([^""]*)""\s*\/>\s*");

            while ((input = Console.ReadLine()) != "<stop/>")
            {
                var match = pattern.Match(input);
                var sb = new StringBuilder();

                if (match.Success)
                {
                    var command = match.Groups[1].Value;
                    var content = match.Groups[3].Value;

                    switch (command)
                    {
                        case "inverse":

                            if (content != "")
                            {
                                foreach (var ch in content)
                                {
                                    if (char.IsLower(ch))
                                    {
                                        sb.Append(ch.ToString().ToUpper());
                                    }

                                    else
                                    {
                                        sb.Append(ch.ToString().ToLower());
                                    }
                                }
                                words.Enqueue(sb.ToString());
                            }
                            break;

                        case "reverse":

                            if (content != "")
                            {
                                for (int i = content.Length - 1; i >= 0; i--)
                                {
                                    sb.Append(content[i].ToString());
                                }
                                words.Enqueue(sb.ToString());
                            }

                            break;

                        case "repeat":
                            var repeats = int.Parse(match.Groups[2].Value);

                            if (repeats != 0 && content != "")
                            {
                                for (int i = 0; i < repeats; i++)
                                {
                                    words.Enqueue(content);
                                }
                            }

                            break;
                    }
                }
            }

            var num = 1;
            while (words.Count > 0)
            {
                var chechPattern = new Regex("^\\s+$");
                var currWord = words.Peek();

                var check = chechPattern.Match(currWord);

                if (check.Success)
                {
                    words.Dequeue();
                }

                else 
                {
                    Console.WriteLine($"{num}. {words.Dequeue()}");
                    num++;
                }
            }
        }
    }
}
