using System;

namespace MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstIndex = text.IndexOf(pattern);
                var secondIndex = text.LastIndexOf(pattern);

                if (firstIndex == -1 || firstIndex == secondIndex)
                {
                    break;
                }

                text = text.Remove(secondIndex, pattern.Length);
                text = text.Remove(firstIndex, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
                Console.WriteLine("Shaked it.");

                if (pattern.Length == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
