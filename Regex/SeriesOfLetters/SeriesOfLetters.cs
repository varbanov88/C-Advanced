using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(Regex.Replace(input, "([A-Za-z])\\1+", "$1"));
        }
    }
}
