using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    public class FindUniqueCharacter
    {
        /*
            Checking if there's any unique character in string using additional datastructure
            T.C. O(n) S.C. O(n)
        */
        public Boolean FindUniqueCharacterFromString(string s)
        {
            if (s == null) return true;

            if (s.Length > 128) return false;

            bool[] array = new bool[128];

            for(int i = 0; i < s.Length; i++)
            {
                if (array[s[i]]) return false;

                array[s[i]] = true;
            }
            return true;
        }

        /*
            Checking if there's any unique character in string without using additional datastructure
            T.C. O(n^2)
        */

        public Boolean FindUniqueCharacterFromStringWithoutDS(string s)
        {

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j]) return false;
                }
            }

            return true;
            /* Use merge/quick sort to sort the string and then check if i & i+1 is similar
             * T.C. (O n logn) 
             */
        }
    }
}
