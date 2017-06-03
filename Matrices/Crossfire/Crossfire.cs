using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int[][] matrix = new int[dimensions[0]][];
            var num = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimensions[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = num;
                    num++;
                }
            }

            var commands = Console.ReadLine();

            while (!commands.Equals("Nuke it from orbit"))
            {
                var commandData = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();
                var row = commandData[0];
                var col = commandData[1];
                var radius = commandData[2];

                matrix[row][col] = 0;

                for (int i = 1; i <= radius; i++)
                {
                    if (col + i < matrix[row].Length)
                    {
                        matrix[row][col + 1] = 0;
                    }

                    if (col - i >= 0)
                    {
                        matrix[row][col - i] = 0;
                    }

                    if (row - i >= 0)
                    {
                        matrix[row - i][col] = 0;
                    }

                    if (row + i <= dimensions[0] - 1)
                    {
                        matrix[row + i][col] = 0;
                    }
                }

                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    var emptyRow = -1;
                    var emptyCol = -1;
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                    {
                        if (true)
                        {

                        }
                    }
                }

                commands = Console.ReadLine();
            }
        }
    }
}
