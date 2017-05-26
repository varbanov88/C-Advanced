using System;
using System.Collections.Generic;

namespace ReverseNumbersWithStack
{
    public class ReverseNumbersWithStack
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                                .Split();
                                

            var stack = new Stack<string>(input);

            foreach (var num in input)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
