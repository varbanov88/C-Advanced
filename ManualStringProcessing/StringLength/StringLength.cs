using System;

namespace StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = input.PadRight(20, '*');

            if (input.Length > 20)
            {
                result = input.Substring(0, 20);
            }

            Console.WriteLine(result);
        }
    }
}
