using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var elementsToPop = int.Parse(input[1]);
            var checkElement = int.Parse(input[2]);

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                if (stack.Contains(checkElement))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
