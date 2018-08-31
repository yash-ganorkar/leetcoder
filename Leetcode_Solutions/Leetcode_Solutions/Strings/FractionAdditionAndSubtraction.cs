using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class FractionAdditionAndSubtraction
    {
        public string FractionAddition(string s) {

            List<char> signs = new List<char>();

            foreach(char c in s)
            {
                if (c == '+') {
                    signs.Add(c);
                }
                else if(c == '-') signs.Add(c);
            }

            List<int> numerator = new List<int>();
            List<int> denominator = new List<int>();

            foreach(string sub in s.Split('+'))
            {
                foreach(string subsub in sub.Split('-'))
                {
                    if(subsub.Length > 0)
                    {
                        string[] fraction = subsub.Split('/');

                        numerator.Add( Convert.ToInt32(fraction[0]));
                        denominator.Add(Convert.ToInt32(fraction[1]));
                    }
                }
            }

            if (s[0] == '-') numerator[0] = -numerator[0];

            int lcm = 1;

            foreach (int x in denominator) {
                lcm = lcm_(lcm, x);
            }

            int res = lcm / denominator[0] * numerator[0];

            for(int i = 1; i < numerator.Count; i++)
            {
                if(signs[i-1] == '+') res += lcm / denominator[i] * numerator[i];
                else res -= lcm / denominator[i] * numerator[i];
            }

            int g = gcd(Math.Abs(lcm), Math.Abs(res));

            return (res / g) + "/" + (lcm / g);
        }

        private int lcm_(int lcm, int x)
        {
            return lcm * x / gcd(lcm, x);
        }

        private int gcd(int lcm, int x)
        {
            while (x != 0) {
                int temp = x;
                x = lcm % x;
                lcm = temp;
            }

            return lcm;
        }
    }
}
