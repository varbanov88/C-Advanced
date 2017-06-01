using System;
using System.Linq;

namespace LegoBlocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var arraysRows = int.Parse(Console.ReadLine());
            long[][] leftMatrix = new long[arraysRows][];
            long[][] rightMatrix = new long[arraysRows][];
            long[][] legoMatrix = new long[arraysRows][];

            for (int i = 0; i < arraysRows; i++)
            {
                leftMatrix[i] = Console.ReadLine()
                                       .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(long.Parse)
                                       .ToArray();
            }

            for (int i = 0; i < arraysRows; i++)
            {
                rightMatrix[i] = Console.ReadLine()
                                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(long.Parse)
                                       .ToArray();
            }

            for (int row = 0; row < legoMatrix.Length; row++)
            {
                legoMatrix[row] = new long[leftMatrix[row].Length + rightMatrix[row].Length];
                var length = leftMatrix[row].Length - 1;
                var col = 0;

                while (length >= 0)
                {
                    legoMatrix[row][col] = leftMatrix[row][col];
                    col++;
                    length--;
                }

                length = rightMatrix[row].Length - 1;
                var rightCol = 0;

                while (length >= 0)
                {
                    legoMatrix[row][col] = rightMatrix[row][length];
                    rightCol++;
                    col++;
                    length--;
                }
            }

            var isMatrix = true;
            var colsCount = 0;

            for (int row = 0; row < legoMatrix.Length; row++)
            {
                if (row < legoMatrix.Length - 1)
                {
                    if (legoMatrix[row].Length != legoMatrix[row + 1].Length)
                    {
                        isMatrix = false;
                    }
                }

                for (int col = 0; col < legoMatrix[row].Length; col++)
                {
                    colsCount++;
                }
            }

            if (isMatrix)
            {
                foreach (var row in legoMatrix)
                {
                    Console.WriteLine("[{0}]", string.Join(", ",row));
                }
            }

            else
            {
                Console.WriteLine("The total number of cells is: " + colsCount);
            }
        }

    }
}
