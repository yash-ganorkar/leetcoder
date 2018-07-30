using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Matrices
{
    class RotateMatrix
    {
        /*
            Given a matrix, n*n, rotate a matrix 90 degree clockwise
         */

        public void MatrixRotation(int[,] matrix, int n)
        {
            for(int i = 0; i < n / 2; i++)
            {
                for(int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];

                    matrix[i, j] = matrix[j, n - 1 - i];

                    matrix[j, n - 1 - i] = matrix[n - 1 - i, n - 1 - j];

                    matrix[n - 1 - i, n - 1 - j] = matrix[n - 1 - j, i];

                    matrix[n - 1 - j, i] = temp;
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine(' ');
            }
        }

        public int[,] RotateMatrixAntiClockWise(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) return matrix;
            else
            {
                int row = matrix.GetLength(0);
                int column = matrix.GetLength(1);

                for(int i =0; i < row / 2; i++)
                {
                    for(int j= i; j < row - i - 1; j++)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[j, row - 1 - i];
                        matrix[j, row - 1 - i] = matrix[row - 1 - i, row - 1 - j];
                        matrix[row - 1 - i, row - 1 - j] = matrix[row - 1 - j, i];
                        matrix[row - 1 - j, i] = temp;
                    }
                }
            }
            return matrix;

        }

        public void RotateMatrixUsingTranspose(int[,] matrix, int N)
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = i; j < N; j++)
                {
                    int temp = matrix[j, i];
                    matrix[j, i] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0, k = matrix.GetLength(0) - 1; j < k; j++, k--)
                {
                    int temp = matrix[j, i];
                    matrix[j, i] = matrix[k, i];
                    matrix[k, i] = temp;
                }
            }
        }
    }
}