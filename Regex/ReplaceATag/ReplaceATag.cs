﻿using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var sb = new StringBuilder();

            while (input != "end")
            {
                sb.AppendLine(input);

                input = Console.ReadLine();
            }

            string pattern = "<a (href=.+?)>(.+)<\\/a>";
            var result = Regex.Replace(sb.ToString(), pattern, w => $"[URL {w.Groups[1]}]{w.Groups[2]}[/URL]");

            Console.WriteLine(result);
        }
    }
}
