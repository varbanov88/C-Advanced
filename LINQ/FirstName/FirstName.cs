using System;
using System.Linq;

namespace FirstName
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            var chars = Console.ReadLine()
                               .Split()
                               .OrderBy(c => c);

            foreach (var ch in chars)
            {
               var result = names.Where(
                   w => w.ToLower()
                         .StartsWith(ch.ToLower()))
                         .FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}
