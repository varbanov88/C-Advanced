using System;
using System.Linq;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var replaceIndex = text.IndexOf(word);
                if (replaceIndex > -1)
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
