using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class ReverseCharactersInString
    {
        /*
            Given a string of words, reverse the order of characters.
         */

        public string ReverseCharacters(string s)
        {

            string[] array = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach(string t in array)
            {
                for(int i = t.Length - 1; i >= 0; i--)
                {
                    sb.Append(t[i]);
                }
                sb.Append(' ');
            }

            return sb.ToString().TrimEnd();
        }
    }
}
