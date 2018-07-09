using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class LongestCommonSubstring
    {
        /*
         * Given two strings, find the longest common subsequence present
         * 
         * Example, s1 = abcvdefgh, s2 = bqdrcvefgh
         */

        public int LongestSubstringCommon(string s1, string s2)
        {
            int[,] array = new int[s1.Length + 1, s2.Length + 1];

            char[] subsequence;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = 0;
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[0, i] = 0;
            }

            for(int i = 1; i < array.GetLength(0); i++)
            {
                char c = s1[i - 1];
                for(int j = 1; j < array.GetLength(1); j++)
                {
                    if (c.Equals(s2[j - 1]))
                    {
                        array[i, j] = array[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        array[i, j] = Math.Max(array[i - 1, j], array[i, j - 1]);
                    }
                }
            }

            int row = s1.Length - 1;
            int column = s2.Length - 1;
            subsequence = new char[array[array.GetLength(0) - 1, array.GetLength(1) - 1]];
            int maxTotal = array[array.GetLength(0) - 1, array.GetLength(1) - 1] - 1;

            

            while(row > -1 && column > -1)
            {
                if (s1[row] == s2[column])
                {
                    subsequence[maxTotal] = s1[row];
                    maxTotal--;
                    row--;
                    column--;
                }

                else
                {
                    if (array[row - 1,column] > array[row,column - 1])
                    {
                        row = row - 1;
                    }
                    else
                    {
                        column = column - 1;
                    }
                }
            }

            foreach(char c in subsequence)
                Console.WriteLine(c);


            return array[array.GetLength(0) - 1, array.GetLength(1) - 1];
        }

    }
}
