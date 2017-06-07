using System;

namespace ParseURLs
{
    public class ParseURLs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var remainer = input.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (remainer.Length != 2 || !remainer[1].Contains("/"))
            {
                Console.WriteLine("Invalid URL");
            }

            else
            {
                int endIndex = remainer[1].IndexOf("/");
                var server = remainer[1].Substring(0, endIndex);
                var resources = remainer[1].Substring(endIndex + 1);

                Console.WriteLine($"Protocol = {remainer[0]}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
