using System;
using System.Collections.Generic;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var mails = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                var emaill = Console.ReadLine();
                var email = emaill.Split('.');
                if (!email[1].ToLower().Equals("us") && !email[1].ToLower().Equals("uk"))
                {
                    mails[name] = emaill;
                }

                name = Console.ReadLine();
            }

            foreach (var pair in mails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
