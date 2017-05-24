using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    public class SimpleCalculator
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var remainer = input.Split();

            var stack = new Stack<string>(remainer.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operant = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operant == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }

                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
