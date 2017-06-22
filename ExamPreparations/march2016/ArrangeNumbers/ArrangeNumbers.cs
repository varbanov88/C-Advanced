using System;
using System.Linq;

namespace ArrangeNumbers
{
    public class ArrangeNumbers
    {
        public static void Main()
        {
            string[] integersNames = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(str => string.Join(string.Empty, str.Select(ch => integersNames[ch - '0'])))));
        }
    }
}
