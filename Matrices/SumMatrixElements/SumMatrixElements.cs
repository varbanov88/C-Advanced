using System;
using System.Linq;

namespace SumMatrixElements
{
    public class SumMatrixElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            var rows = input[0];
            var cols = input[1];
            int[][] matrix = new int[rows][];

            var sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    sum += matrix[row][col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
