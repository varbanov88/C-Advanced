using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var regex = new Regex(@"^\+359( |-)2\1[0-9]{3}\1[0-9]{4}$");

            var input = Console.ReadLine();

            while (input != "end")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
