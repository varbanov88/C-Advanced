using System;
using System.Collections.Generic;
using System.Text;

namespace NMS
{
    public class NMS
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine();

            var sb = new StringBuilder();

            while (stringInput != "---NMS SEND---")
            {
                sb.Append(stringInput);
                stringInput = Console.ReadLine();
            }

            var chars = new Queue<char>(sb.ToString());
            sb.Clear();

            var words = new Queue<string>();

            while (chars.Count > 0)
            {
                var currChar = chars.Dequeue();
                sb.Append(currChar);

                if (chars.Count == 0 || char.ToLower(currChar) > char.ToLower(chars.Peek()))
                {
                    words.Enqueue(sb.ToString());
                    sb.Clear();
                }
            }

            var delimiter = Console.ReadLine();

            Console.WriteLine(string.Join($"{delimiter}", words));
        }
    }
}
