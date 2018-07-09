using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class PalindromePermutation
    {
        /*
            Given a string, check if it is a permutation of palindrome.

            Example, aab return true because it is a permutation of aba.
         */

        public Boolean Permutation(string s)
        {
            /*
             Solution 1. Maintain frequency count of all the letters present in string s.
                         Check if the array contains multiple occurences of a single letter.
                         If it does, it is not a palindrome permutation

            Example, abcbca
                   [2,2,2] since all of the digits are even, the string is palindrome

            Example, abbca
                   [2,2,1] since there is one occurence of an letter which is odd, it is a palindrome
            
            Example, abcda
                   [2,1,1,1] since there are multiple occurences of a single letter, it is not a palindrome
                   
             */

            int[] array = new int[26];

            int oddOccurence = 0;

            s = s.ToLower();

            for(int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                array[index]++;
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) oddOccurence++;
            }

            if (oddOccurence > 1) return false;

            return true;
        }
    }
}
