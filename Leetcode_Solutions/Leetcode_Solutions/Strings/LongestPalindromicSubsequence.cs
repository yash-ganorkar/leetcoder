using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class LongestPalindromicSubsequence
    {
        /*
            Given a string, find the longest palindromic subsequence

            Example, aaaabbaa
                    Output -> 6, aabbaa
         */

        public string LongestSubsequencePalindrome(string s)
        {
            /*
             * Solution :- Construct a n*n matrix where n is length of input string
             *             set all diagonal elements to 1, and all the elements below diagonal to 0.
             *             
             *             if character matches, then assign that cell value equal to 2 + diagonally bottom value
             *             else taken maximum of (matrix[i,j-1], matrix[i+1,j]
             *             
             *             the top right corner will have the maximum length of the subsequence
             T.C. O(n^2)
             */

            int[,] array = new int[s.Length,s.Length];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j) array[i, j] = 1;
                }
            }

            int l = 1;
            while (l <= s.Length - 1)
            {
                int i = 0;
                while (i + l <= s.Length - 1)
                {
                    int j = i + l;
                    if (s[i] == s[j])
                        array[i,j] = array[i + 1,j - 1] + 2;
                    else
                    {
                        if (array[i + 1,j] > array[i,j - 1])
                            array[i,j] = array[i + 1,j];
                        else
                            array[i,j] = array[i,j - 1];
                    }

                    i = i + 1;
                }

                l = l + 1;
            }
            return "";
        }
    }
}
