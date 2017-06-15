using System;

namespace PredicateForNames
{
    public class PredicateForNames
    {
        public static void Main()
        {
            var nameLegth = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> checkLength = n => n.Length <= nameLegth;

            foreach (var name in names)
            {
                if (checkLength(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
