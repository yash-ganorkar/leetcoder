using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class FirstNonRepeatingCharacter
    {
        /*
         * Given a string, find the first non-repeating character
         * Example , hello -> 'h' is first non repeating character
         */

        public char NonRepeatingCharacter(string s)
        {

            /*
             * Solution :- Maintain an array.. which maintains count of occurences of characters in the 
             *              string.
             */

            int[] count = new int[26];

            s = s.ToLower();
            int index = -1;
            for(int i = 0; i < s.Length; i++)
            {
                int ind = s[i] - 'a';
                count[ind]++;
            }

            for(int i = 0; i < s.Length; i++)
            {
                int ind = s[i] - 'a';
                if (count[ind] == 1)
                {
                    index = i;
                    break;
                }
            }

            return s[index];
        }
    }
}
