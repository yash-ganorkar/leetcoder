using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class CheckIfStringIsPermutation
    {
        /*
            Given Two Strings, check whether one string is permutation of other

            "sumit" and "tiums" are permutations of each other.
            "abcd" and bdea" are not permutations of each other.
        */
        public Boolean PermutationString(string s1, string s2)
        {
            /*
             Solution 1. Sort s1 & s2 in ascending or descending order...
                         Check if both the strings are similar or not...

                        T.C. O(n logn)

            char[] s1Char = s1.ToCharArray();
            char[] s2Char = s2.ToCharArray();

            Array.Sort(s1Char);
            Array.Sort(s2Char);

            s1 = Convert.ToString(s1Char);
            s2 = Convert.ToString(s2Char);

            if (s1.Equals(s2)) return true;
            else return false;
             */

            /*
             Solution 2. Create an integer array of length equals to s1.
                         Keep an count of number of occurences of particular character in s1.
                         Decrease the count whenever the same letter occurs in s2.
                         Finally, loop through the array, checking if all the inputs are 0.

                         T.C. O(n) S.C O(n)
             */

            int[] array = new int[26];

            s1 = s1.ToLower();
            s2 = s2.ToLower();
            for(int i = 0; i < s1.Length; i++)
            {
                int index = s1[i] - 'a';

                array[index]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                int index = s1[i] - 'a';

                array[index]--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) return false;
            }
            return true;
        }
    }
}
