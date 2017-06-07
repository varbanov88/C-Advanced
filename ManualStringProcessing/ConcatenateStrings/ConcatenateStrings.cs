using System;
using System.Text;

namespace ConcatenateStrings
{
    public class ConcatenateStrings
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var sensentence = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                var word = Console.ReadLine();
                sensentence.Append(word + " ");
            }

            Console.WriteLine(sensentence);
        }
    }
}
