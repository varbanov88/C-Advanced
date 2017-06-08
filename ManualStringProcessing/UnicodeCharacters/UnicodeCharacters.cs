using System;
using System.Text;

namespace UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char ch in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)ch));
            }
            Console.WriteLine(sb);
        }
    }
}
