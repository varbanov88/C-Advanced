using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    public class BalancedParenthesis
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().Trim();
            var input = new Queue<char>(inputString);

            var stack = new Stack<char>();
            var isBalanced = true;

            while (input.Count > 0)
            {
                var ch = input.Dequeue();
                if (ch.Equals('{') || ch.Equals('[') || ch.Equals('('))
                {
                    stack.Push(ch);
                }

                else
                {
                    if (stack.Count > 0)
                    {
                        var check = stack.Pop();
                        if (check.Equals('{'))
                        {
                            if (!ch.Equals('}'))
                            {
                                isBalanced = false;
                                break;
                            }
                        }

                        else if (check.Equals('['))
                        {
                            if (!ch.Equals(']'))
                            {
                                isBalanced = false;
                                break;
                            }
                        }

                        else
                        {
                            if (!ch.Equals(')'))
                            {
                                isBalanced = false;
                                break;
                            }
                        }
                    }

                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
