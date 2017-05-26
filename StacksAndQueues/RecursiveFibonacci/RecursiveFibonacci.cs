using System;

namespace RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            fibNumbers = new long[num];

            var result = GetFibonacci(num);
            Console.WriteLine(result);
        }

        private static long GetFibonacci(int num)
        {
            if (num <= 2)
            {
                return 1;
            }

            if (fibNumbers[num - 1] != 0)
            {
                return fibNumbers[num - 1];
            }
            return fibNumbers[num - 1] = GetFibonacci(num - 1) + GetFibonacci(num - 2);
        }
    }
}
