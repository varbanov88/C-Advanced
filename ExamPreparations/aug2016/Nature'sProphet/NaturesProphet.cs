using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature_sProphet
{
    public class NaturesProphet
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] matrix = new int[dimentions[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimentions[1]];
                for (int col = 0; col < dimentions[1]; col++)
                {
                    matrix[row][col] = 0;
                }
            }

            var fill = Console.ReadLine();
            var fillers = new SortedSet<string>();

            while (fill != "Bloom Bloom Plow")
            {
                fillers.Add(fill);
                var dims = fill.Split().Select(int.Parse).ToArray();

                matrix[dims[0]][dims[1]] = 1;

                fill = Console.ReadLine();
            }

            foreach (var dim in fillers)
            {
                var tokens = dim.Split().Select(int.Parse).ToArray();
                var row = tokens[0];
                var col = tokens[1];
                matrix = FillMatrix(matrix, row, col);
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static int[][] FillMatrix(int[][] matrix, int row, int col)
        {
            matrix = FillLeft(matrix, row, col);
            matrix = FillRight(matrix, row, col);
            matrix = FillUp(matrix, row, col);
            matrix = FillDown(matrix, row, col);

            return matrix;
        }

        private static int[][] FillDown(int[][] matrix, int row, int col)
        {
            var matrice = matrix;

            for (int i = row + 1; i < matrice.Length; i++)
            {
                matrice[i][col] += 1;
            }

            return matrice;
        }

        private static int[][] FillUp(int[][] matrix, int row, int col)
        {
            var matrice = matrix;

            for (int i = row - 1; i >= 0; i--)
            {
                matrice[i][col] += 1;
            }

            return matrice;
        }

        private static int[][] FillRight(int[][] matrix, int row, int col)
        {
            var matrice = matrix;
            for (int i = col + 1; i < matrice[row].Length; i++)
            {
                matrice[row][i] += 1;
            }

            return matrice;
        }

        private static int[][] FillLeft(int[][] matrix, int row, int col)
        {
            var matrice = matrix;

            for (int i = 0; i < col; i++)
            {
                matrice[row][i] += 1;
            }

            return matrice;
        }
    }
}
