using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                if (word.Length == 1)
                {
                    palindromes.Add(word);
                }

                else
                {
                    var isPalindrom = true;

                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        var firstChar = word[i];
                        var lastChar = word[word.Length - 1 - i];

                        if (firstChar != lastChar)
                        {
                            isPalindrom = false;
                            break;
                        }
                    }

                    if (isPalindrom)
                    {
                        palindromes.Add(word);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }
    }
}
