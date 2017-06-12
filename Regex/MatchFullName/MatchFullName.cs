using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var regex = new Regex(@"^[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}$");
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
