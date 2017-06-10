using System;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var regex = new Regex(@"^[\w+-]{3,16}$");
            var input = Console.ReadLine();

            while (input != "END")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }

                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();

            }
        }
    }
}
