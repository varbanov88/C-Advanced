using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractice
{
    public class TargetPractice
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            char[][] matrix = new char[dimentions[0]][];

            var stringSnake = Console.ReadLine().Trim();
            var snake = new Queue<char>(stringSnake);
            var shotImpact = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            bool isMovingLeft = true;

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[dimentions[1]];

                if (isMovingLeft)
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        matrix[row][col] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }

                else
                {
                    for (int colum = 0; colum < matrix[row].Length; colum++)
                    {
                        matrix[row][colum] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }

                isMovingLeft = !isMovingLeft;
            }

            var impactRow = shotImpact[0];
            var impactCol = shotImpact[1];
            var impactRadius = shotImpact[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (IsInsideMatrix(row, col, impactRow, impactCol, impactRadius))
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != ' ')
                    {
                        continue;
                    }

                    int currentRow = row - 1;
                    while (currentRow >= 0)
                    {
                        if (matrix[currentRow][col] != ' ')
                        {
                            matrix[row][col] = matrix[currentRow][col];
                            matrix[currentRow][col] = ' ';
                            break;
                        }

                        currentRow--;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        public static bool IsInsideMatrix(int checkRow, int checkCol, int impactRow, int impactCol, int impactRadius)
        {
            int deltaRow = checkRow - impactRow;
            int deltaCol = checkCol - impactCol;

            bool isInRadius = deltaRow * deltaRow + deltaCol * deltaCol <= impactRadius * impactRadius;

            return isInRadius;
        }
    }
}
