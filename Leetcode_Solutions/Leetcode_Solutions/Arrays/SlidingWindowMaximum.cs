using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] max_left = new int[nums.Length];
            int[] max_right = new int[nums.Length];

            max_left[0] = nums[0];
            max_right[nums.Length - 1] = nums[nums.Length - 1];

            for (int i = 1; i < nums.Length; i++) {
                max_left[i] = (i % k == 0) ? nums[i] : Math.Max(max_left[i - 1], nums[i]);

                int j = nums.Length - i - 1;
                max_right[j] = (j % k == 0) ? nums[j] : Math.Max(max_right[j + 1], nums[j]);
            }

            int[] sliding_max = new int[nums.Length - k + 1];
            for (int i = 0, j = 0; i + k <= nums.Length; i++) {
                sliding_max[j++] = Math.Max(max_right[i], max_left[i + k - 1]);
            }
            return sliding_max;
        }
    }
}
