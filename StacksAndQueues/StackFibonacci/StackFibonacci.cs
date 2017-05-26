using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            for (int i = 2; i <= n; i++)
            {
                var secondNum = stack.Pop();
                var firstNum = stack.Peek();
                stack.Push(secondNum);
                stack.Push(firstNum + secondNum);
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
