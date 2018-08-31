using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            int diff = 0;

            //GET XOR of the 2 digits we need to find

            foreach(int n in nums)
            {
                diff ^= n;
            }

            diff &= -diff;

            int[] rets = new int[] { 0, 0 }; // this array stores the two numbers we will return

            foreach (int n in nums)
            {
                if ((n & diff) == 0) rets[0] ^= n; //this bit is not set
                else rets[1] ^= n; //this bit is set
            }

            return rets;
        }
    }
}
