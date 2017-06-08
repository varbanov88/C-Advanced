using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0];
            var secondWord = input[1];

            Console.WriteLine(AreExchangeable(firstWord, secondWord).ToString().ToLower());
        }

        private static bool AreExchangeable(string firstWord, string secondWord)
        {
            var areMagic = true;

            var firstChars = new Queue<char>(firstWord);
            var secondChars = new Queue<char>(secondWord);
            var firstSet = new HashSet<char>();
            var secondSet = new HashSet<char>();

            while (firstChars.Count > 0)
            {
                firstSet.Add(firstChars.Dequeue());
            }

            while (secondChars.Count > 0)
            {
                secondSet.Add(secondChars.Dequeue());
            }

            if (firstSet.Count != secondSet.Count)
            {
                areMagic = false;
            }

            return areMagic;
        }
    }
}
