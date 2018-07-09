using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class PermutationsOfString
    {
        /*
         * Given a string as input, print all the permutations of the string.
         */

        public void StringPermutations(string s)
        {
            if (s == null || s.Length == 0) return;

            StringPermutationHelper(s, "");
        }

        /*
            Solution : if string is empty, print the new string
                        else
                            For each character in string,
                            append the character to a new string,
                            remove it from the original string,
                            call the function,
                            insert the new string at 1st position in the original string
                            remove the character from last from the new string
         */

        private void StringPermutationHelper(string s, string v)
        {
            if (s == null || s.Length == 0) Console.WriteLine(v);

            else
            {
                for(int i = 0; i < s.Length; i++)
                {
                    char c = s[i];

                    v += c;

                    s = s.Remove(i, 1);

                    StringPermutationHelper(s, v);

                    s = s.Insert(i, c.ToString());
                    v = v.Remove(v.Length - 1,1);

                }

            }

        }
    }
}
