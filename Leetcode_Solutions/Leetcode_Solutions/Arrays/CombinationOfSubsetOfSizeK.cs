using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class CombinationOfSubsetOfSizeK
    {
        int maximumSum = int.MinValue;
        public void SubsetOfSizeK(int[] array, int k)
        {
            bool[] used = new bool[array.Length];

            SubsetOfSizeKHelper(array, k, 0, 0, used);
        }

        private void SubsetOfSizeKHelper(int[] array, int k, int start, int currLen, bool[] used)
        {
           if(currLen == k)
            {
                int sum = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if (used[i] == true)
                    {
                        sum += array[i];
                        Console.Write(array[i] + " ");
                    }
                }
                Console.WriteLine();
                if (maximumSum < sum) maximumSum = sum;
                Console.WriteLine("Sum => {0}", maximumSum);
                return;
            }

            if (start == array.Length) return;

            //1. Either we select the number, by putting true against it and make currLen+1
            used[start] = true;
            SubsetOfSizeKHelper(array, k, start + 1, currLen + 1, used);

            //2. Either we do not select the number, by putting false against it and do not make currLen+1
            used[start] = false;
            SubsetOfSizeKHelper(array, k, start + 1, currLen, used);
        }
    }
}
