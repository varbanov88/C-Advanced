using System;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                long headOfQueue = queue.Peek();
                queue.Enqueue(headOfQueue + 1);
                queue.Enqueue(headOfQueue * 2 + 1);
                queue.Enqueue(headOfQueue + 2);

                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
