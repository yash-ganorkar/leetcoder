using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class StringRotation
    {
        /*
         Given 2 strings, s1 and s2, write a code to check if s2 is a rotation of s1.

            s1 = "waterbottle"
            s2 = "erbottlewat"

        If we have to split s1, x = wat, y = erbottle which is xy
        If we split s2 using wat, x = erbottle, y = wat which is yx

        If we concatenate s1 with s1, we get xyxy, we see, we get yx as substring of xyxy.
        Applying similar logic, we can find if s2 is rotation of s1
         */

        public Boolean IsSubstring(string s1, string s2)
        {
            s1 += s1;

            return s1.Contains(s2) ? true : false;
        }
    }
}
