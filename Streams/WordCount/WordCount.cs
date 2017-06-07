using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            var wordsCount = new Dictionary<string, int>();
            var wordsPath = "../../words.txt";

            using (var reader = new StreamReader(wordsPath))
            {
                var readLine = reader.ReadLine();
                while (readLine != null)
                {
                    wordsCount[readLine] = 0;
                    readLine = reader.ReadLine();
                }
            }

            var textPath = "../../text.txt";
            using (var reader = new StreamReader(textPath))
            {
                var readLine = reader.ReadLine();

                while (readLine != null)
                {
                    var words = readLine
                        .Split(new[] { ' ', '-', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    foreach (var word in words)
                    {
                        if (wordsCount.ContainsKey(word.ToLower()))
                        {
                            wordsCount[word.ToLower()]++;
                        }
                    }
                    readLine = reader.ReadLine();
                }
            }

            using (var writer = new StreamWriter("../../result.txt"))
            {
                foreach (var word in wordsCount.OrderByDescending(n => n.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
