using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveBunnies
{
    public class RadioactiveBunnies
    {
        public static void Main()
        {
            //not finished
            var dimentions = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            char[][] matrix = new char[dimentions[0]][];
            var row = 0;
            var col = 0;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToArray();
                if (matrix[rowIndex].Contains('P'))
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == 'P')
                        {
                            row = rowIndex;
                            col = colIndex;
                        }
                    }
                }
            }

            var commands = Console.ReadLine();
            var playerDies = false;
            var isOut = false;

            }
        }
    }
}
