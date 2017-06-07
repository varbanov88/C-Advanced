using System;

namespace ParseTags
{
    public class ParseTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var openTag = "<upcase>";
            var openTagIndex = input.IndexOf(openTag);

            while (openTagIndex > -1)
            {
                var closeTag = "</upcase>";
                var closeTagIndex = input.IndexOf("</upcase>");

                if (closeTagIndex == -1)
                {
                    break;
                }

                var toBeReplaced = input.Substring(openTagIndex, closeTagIndex + closeTag.Length - input.IndexOf(openTag));
                var replaced = toBeReplaced.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();
                input = input.Replace(toBeReplaced, replaced);

                openTagIndex = input.IndexOf(openTag);
            }

            Console.WriteLine(input);
        }
    }
}
