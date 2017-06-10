using System;

namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string line = Console.ReadLine().ToLower();
            string check = Console.ReadLine().ToLower();

            int maxIndex = line.Length - check.Length;
            int counter = 0;

            for (int i = 0; i <= maxIndex; i++)
            {
                string substring = line.Substring(i, check.Length);
                if (substring.Equals(check))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
