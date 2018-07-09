using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class ReverseWordsInAString
    {
        /*
         Given a string, reverse the words in the string.
         Example, I -> "my name is Yash"
                  O -> "Yash is name my"
         */

        public string ReverseWords(string s)
        {
            string[] wordsArray = s.Split(' ');

            StringBuilder sb = new StringBuilder();

            int i = wordsArray.Length - 1;

            while(i > 0)
            {
                sb.Append(wordsArray[i]);
                sb.Append(' ');
                i--;
            }

            sb.Append(wordsArray[i]);

            return sb.ToString();
        }
    }
}
