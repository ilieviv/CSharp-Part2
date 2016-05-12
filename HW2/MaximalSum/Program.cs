using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i]);
            }

            int[,] matrix = new int[num[0], num[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] cells = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(cells[col]);
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 2, col] +
                        matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
