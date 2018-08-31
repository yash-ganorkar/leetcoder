using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class ToLowerCase
    {
        public string ToLowerCaseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                int index = Convert.ToInt32(c);

                if (index <= 90 && index >= 65)
                {
                    sb.Append(Convert.ToChar(index+32));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
