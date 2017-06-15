using System;
using System.Linq;

namespace SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Action<int[]> output = PrintArrayNumbersLenthAndSum;

            output(input);
        }

        public static void PrintArrayNumbersLenthAndSum(int[] input)
        {
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }

        
    }
}
