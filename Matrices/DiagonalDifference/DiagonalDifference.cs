using System;
using System.Linq;

namespace DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var height = int.Parse(Console.ReadLine());

            long[][] matrix = new long[height][];
            long leftDiagonalSum = 0;
            long rightDiagonalSum = 0;

            for (int i = 0; i < height; i++)
            {
                matrix[i] = Console.ReadLine()
                                    .Split()
                                    .Select(long.Parse)
                                    .ToArray();

                leftDiagonalSum += matrix[i][i];
                rightDiagonalSum += matrix[i][matrix[i].Length - 1 - i];

            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
