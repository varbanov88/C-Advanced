using System;
using System.Collections.Generic;

namespace CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            MultiplyChars(input);
        }

        private static void MultiplyChars(string input)
        {
            var strings = input.Split();
            var firstString = new Queue<char>(strings[0]);
            var secondString = new Queue<char>(strings[1]);

            var sum = 0;

            while (firstString.Count > 0 && secondString.Count > 0)
            {
                sum += (int)firstString.Dequeue() * (int)secondString.Dequeue();
            }
            var addToSum = AddLeftChars(firstString, secondString);

            Console.WriteLine(sum + addToSum);
        }

        private static int AddLeftChars(Queue<char> firstString, Queue<char> secondString)
        {
            var sum = 0;

            if (firstString.Count != 0)
            {
                while (firstString.Count > 0)
                {
                    sum += (int)firstString.Dequeue();
                }
            }

            if (secondString.Count != 0)
            {
                while (secondString.Count > 0)
                {
                    sum += (int)secondString.Dequeue();
                }
            }


            return sum;
        }
    }
}
