using System;
using System.Text.RegularExpressions;

namespace ValidTime
{
    public class ValidTime
    {
        public static void Main()
        {
            var regex = new Regex(@"[01][0-9]:[0-5]{2}:[0-5]{2} (A|P)M");
            var clock = Console.ReadLine();

            while (clock != "END")
            {
                var match = regex.Match(clock);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }

                else
                {
                    Console.WriteLine("invalid");
                }

                clock = Console.ReadLine();
            }
        }
    }
}
