using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Matrices
{
    class FlippinganImage
    {
        public int[,] FlipAndInvertImage(int[,] A)
        {
            for (int row = 0; row < A.GetLength(0); row++)
            {
                for(int col = 0; col < (A.GetLength(1) / 2); col++)
                {
                    int temp = A[row, col];
                    A[row, col] = A[row,A.GetLength(1)-col-1];
                    A[row, A.GetLength(1) - col - 1] = temp;
                }
            }

            for (int row = 0; row < A.GetLength(0); row++)
            {
                for (int col = 0; col < A.GetLength(1); col++)
                {
                    int temp = A[row, col];

                    if (temp == 0) A[row, col] = 1;
                    else A[row, col] = 0;
                }
            }

            return A;
        }

    }
}
