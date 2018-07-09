using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Matrices
{
    class ZeroMatrix
    {
        /*
            Write an algorithm such that if an element in an M*N matrix is 0, it's entire row and column
            are set to 0.
         */

        public void MatrixRowColumnZero(int[,] matrix)
        {
            /*
              Solution 1. Check if the first row and column has 0
                          Check if there are 0s in rest of the matrix, if found, add 0s to row and column
                          Nullify row, based on values in first column
                          Nullify column, based on values in first row
                          Nullify first row
                          Nullify first column
                          
             */

            bool rowHasZero = false;
            bool columnHasZero = false;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if(matrix[i,0] == 0)
                {
                    columnHasZero = true;
                    break;
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[0, i] == 0)
                {
                    rowHasZero = true;
                    break;
                }
            }

            for(int i = 1; i < matrix.GetLength(0); i++)
            {
                for(int j = 1; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }

            for(int i = 1; i < matrix.GetLength(0); i++)
            {
                if(matrix[i,0] == 0)
                {
                    NullifyRow(matrix, i);
                }
            }

            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                if (matrix[0, i] == 0)
                {
                    NullifyColumn(matrix, i);
                }
            }

            if (rowHasZero) NullifyRow(matrix, 0);
            if (columnHasZero) NullifyColumn(matrix, 0);

        }

        private void NullifyColumn(int[,] matrix, int j)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j] = 0;
            }
        }

        private void NullifyRow(int[,] matrix, int i)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
            }
        }
    }
}
