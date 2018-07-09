using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class CheckForAnagram
    {
        /*
         * Given a string, find if the given string is anagram of another string.
         * 
         * Example, s1 = abc s2 = cab
         */

        public Boolean IsAnagram(string s1, string s2)
        {

            if (s1.Length != s2.Length) return false;

            char[] array = new char[256];

            for(int i=0; i < s1.Length; i++)
            {
                array[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                array[s2[i]]--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 1) return false;
            }

            return true;
        }
    }
}
