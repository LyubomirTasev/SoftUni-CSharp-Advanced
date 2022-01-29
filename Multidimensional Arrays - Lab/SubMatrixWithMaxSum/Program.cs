using System;
using System.Linq;

namespace SubMatrixWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int[] subMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int subRows = subMatrix[0];
            int subCols = subMatrix[1];

            int maxSum = 0;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row <= matrix.GetLength(0) - subRows; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - subCols; col++)
                {
                    int currentSum = 0;

                    for (int i = 0; i < subRows; i++)
                    {
                        for (int j = 0; j < subCols; j++)
                        {
                            currentSum += matrix[row + i, col + j];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = maxSumRow; row < maxSumRow + subRows; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + subCols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
