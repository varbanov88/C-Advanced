using System;
using System.Collections.Generic;

namespace StringMatrixRotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            //judge result: 80/100
            var rotationCommand = Console.ReadLine().Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var rotation = int.Parse(rotationCommand[1]);
            var words = new Queue<string>();
            var longestStringLength = 0;
            var input = Console.ReadLine().Trim();

            while (input != "END")
            {
                words.Enqueue(input);
                if (input.Length > longestStringLength)
                {
                    longestStringLength = input.Length;
                }

                input = Console.ReadLine().Trim();
            }

            char[][] matrix = new char[words.Count][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[longestStringLength];
                var word = words.Dequeue();

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (j < word.Length)
                    {
                        matrix[i][j] = word[j];
                    }

                    else
                    {
                        matrix[i][j] = ' ';

                    }
                }
            }


            var rotationCount = (rotation / 90) % 4;


            if (rotationCount == 1)
            {
                char[][] finalMatrix = new char[matrix[0].Length][];

                for (int row = 0; row < finalMatrix.Length; row++)
                {
                    finalMatrix[row] = new char[matrix.Length];
                    for (int col = 0; col < finalMatrix[row].Length; col++)
                    {
                        finalMatrix[row][col] = matrix[matrix.Length - 1 - col][row];
                    }
                }

                foreach (var row in finalMatrix)
                {
                    Console.WriteLine(row);
                }
            }

            else if (rotationCount == 2)
            {
                char[][] finalMatrix = new char[matrix.Length][];

                for (int row = 0; row < finalMatrix.Length; row++)
                {
                    finalMatrix[row] = new char[matrix[row].Length];
                    var counter = 0;
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        finalMatrix[row][counter] = matrix[matrix.Length - 1 - row][col];
                        counter++;
                    }
                }

                foreach (var row in finalMatrix)
                {
                    Console.WriteLine(row);
                }
            }

            else if (rotationCount == 3)
            {
                char[][] finalMatrix = new char[matrix[0].Length][];

                for (int row = 0; row < finalMatrix.Length; row++)
                {
                    finalMatrix[row] = new char[matrix.Length];
                    for (int col = 0; col < finalMatrix[row].Length; col++)
                    {
                        finalMatrix[row][col] = matrix[col][matrix[col].Length - 1 - row];
                    }
                }

                foreach (var row in finalMatrix)
                {
                    Console.WriteLine(row);
                }
            }

            else
            {
                foreach (var row in matrix)
                {
                    Console.WriteLine(row);
                }
            }
        }
    }
}
