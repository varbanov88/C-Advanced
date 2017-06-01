using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            long[][] matrix = new long[input[0]][];
            long maxSum = long.MinValue;
            var rowMax = 0;
            var colMax = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(long.Parse)
                   .ToArray();
            }

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                     matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                     matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowMax = row;
                        colMax = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[rowMax][colMax]} {matrix[rowMax][colMax + 1]} {matrix[rowMax][colMax + 2]}");
            Console.WriteLine($"{matrix[rowMax + 1][colMax]} {matrix[rowMax + 1][colMax + 1]} {matrix[rowMax + 1][colMax + 2]}");
            Console.WriteLine($"{matrix[rowMax + 2][colMax]} {matrix[rowMax + 2][colMax + 1]} {matrix[rowMax + 2][colMax + 2]}");
        }
    }
}
