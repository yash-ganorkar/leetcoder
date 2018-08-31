using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class FindPeakElement
    {
        public int FindPeakElementInArray(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right) {
                int mid = (left + right) / 2;

                if (nums[mid] < nums[mid + 1]) left = mid + 1;
                else right = mid;
            }

            return left;
        }
    }
}
