using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    public class SquareWithMaximumSum
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

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            }

            var sum = 0;
            var maxRow = 0;
            var maxCol = 0;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var newSum = matrix[row][col] + matrix[row][col + 1] +
                                 matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (newSum > sum)
                    {
                        maxCol = col;
                        maxRow = row; 
                        sum = newSum;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1][maxCol]} {matrix[maxRow + 1][maxCol + 1]}");
            Console.WriteLine(sum);
        }
    }
}
