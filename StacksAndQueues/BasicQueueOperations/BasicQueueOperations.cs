using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var elementsToDequeue = int.Parse(input[1]);
            var checkElement = int.Parse(input[2]);

            var numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                if (queue.Contains(checkElement))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

        }
    }
}
