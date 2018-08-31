using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;

            int ans = 0, left = 0, prod = 1;

            for (int i = 0; i < nums.Length; i++) {
                prod *= nums[i];
                while (prod >= k) prod /= nums[left++];

                ans += i - left + 1;
            }

            return ans;
        }
    }
}
