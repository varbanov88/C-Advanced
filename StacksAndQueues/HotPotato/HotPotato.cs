using System;
using System.Collections.Generic;

namespace HotPotato
{
    public class HotPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var queue = new Queue<string>(input);
            var num = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    string remainer = queue.Dequeue();
                    queue.Enqueue(remainer);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
