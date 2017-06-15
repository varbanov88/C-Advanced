using System;
using System.Linq;

namespace CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            Func<int[], int> printMinNum = FindMinNum;

            Console.WriteLine(printMinNum(input));
        }

        public static int FindMinNum(int[] input)
        {
            return input.Min();
        }
    }
}
