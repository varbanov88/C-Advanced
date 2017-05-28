using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var user = Console.ReadLine();
                userNames.Add(user);
            }

            foreach (var user in userNames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
