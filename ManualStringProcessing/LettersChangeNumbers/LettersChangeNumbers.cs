using System;
using System.Collections.Generic;
using System.Text;

namespace LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            decimal sum = 0;

            foreach (var entry in input)
            {
                var infrontChars = new Queue<char>();
                var backChars = new Queue<char>();

                var sb = new StringBuilder();
                var foundNum = false;

                for (int i = 0; i < entry.Length; i++)
                {
                    if (!foundNum)
                    {
                        if (Char.IsDigit(entry[i]))
                        {
                            sb.Append(entry[i]);
                            if (!Char.IsDigit(entry[i + 1]))
                            {
                                foundNum = true;
                            }
                        }

                        else
                        {
                            infrontChars.Enqueue(entry[i]);
                        }
                    }

                    else
                    {
                        backChars.Enqueue(entry[i]);
                    }
                }

                sum += CalculateSum(infrontChars, backChars, sb.ToString(), alphabet);
            }

            Console.WriteLine("{0:f2}", sum);
        }

        private static decimal CalculateSum(Queue<char> infrontChars, Queue<char> backChars, string sb, string alphabet)
        {
            var num = decimal.Parse(sb);

            while (infrontChars.Count > 0)
            {
                var ch = infrontChars.Dequeue();

                if (Char.IsUpper(ch))
                {
                    num = num / (alphabet.IndexOf(ch.ToString().ToLower()) + 1);
                }

                else
                {
                   num = num * (alphabet.IndexOf(ch) + 1);
                }
            }

            while (backChars.Count > 0)
            {
                var ch = backChars.Dequeue();

                if (Char.IsUpper(ch))
                {
                    num = num - (alphabet.IndexOf(ch.ToString().ToLower()) + 1);
                }

                else
                {
                    num = num + alphabet.IndexOf(ch) + 1;
                }
            }

            return num;
        }
    }
}
