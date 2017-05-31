using System;
using System.Linq;
using System.Text;

namespace MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[][] matrix = new string[input[0]][];

            for (int row = 0; row < input[0]; row++)
            {
                matrix[row] = new string[input[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    var pol = new StringBuilder();
                    pol.Append(alphabet[row]);
                    pol.Append(alphabet[row + col]);
                    pol.Append(alphabet[row]);

                    matrix[row][col] = pol.ToString();
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
