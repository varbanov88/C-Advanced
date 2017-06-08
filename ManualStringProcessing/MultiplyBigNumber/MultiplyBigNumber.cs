using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart('0');
            var secondNum = int.Parse(Console.ReadLine());

            if (secondNum == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                var number = new Stack<char>(firstNum);
                var resultNum = new Stack<int>();

                var remainer = 0;

                while (number.Count > 0)
                {
                    var num = int.Parse(number.Pop().ToString());
                    var result = num * secondNum + remainer;
                    var numToAdd = ((num * secondNum) + remainer) % 10;
                    resultNum.Push(numToAdd);

                    if (result > 9)
                    {
                        remainer = result / 10;

                    }

                    else
                    {
                        remainer = 0;
                    }
                }

                if (remainer != 0)
                {
                    resultNum.Push(remainer);
                }

                var sb = new StringBuilder();

                while (resultNum.Count > 0)
                {
                    sb.Append(resultNum.Pop());
                }

                Console.WriteLine(sb);
            }
        }
    }
}
