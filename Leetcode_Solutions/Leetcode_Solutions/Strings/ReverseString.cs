using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class ReverseString
    {
        /*
         * Given a string, reverse the given string. Use recursive as well as iterative
         * 
         * Example, s = "Yash", Output -> "hsaY"
         */


        public string ReverseStringUsingIteration(string s)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = s.Length - 1; i >=0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        public string ReverseStringUsingRecursion(string s)
        {
             return ReverseStringUsingRecursionHelper(s, "");
        }

        private string ReverseStringUsingRecursionHelper(string s, string reversed)
        {
            if (s.Length == 0 || s == null) {
                return reversed;
            }

            else
            {
                reversed += s[s.Length - 1];
                return ReverseStringUsingRecursionHelper(s.Substring(0, s.Length - 1), reversed);
            }

        }
    }
}
