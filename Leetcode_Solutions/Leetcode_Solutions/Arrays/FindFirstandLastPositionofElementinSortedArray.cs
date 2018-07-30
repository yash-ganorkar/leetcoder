using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{
    class FindFirstandLastPositionofElementinSortedArray
    {
        /*
         Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        Your algorithm's runtime complexity must be in the order of O(log n).

        If the target is not found in the array, return [-1, -1].

        Example 1:

            Input: nums = [5,7,7,8,8,10], target = 8
            Output: [3,4]

        Example 2:

            Input: nums = [5,7,7,8,8,10], target = 6
            Output: [-1,-1]
         */

        public int[] SearchRange(int[] nums, int target)
        {
            int[] array = new int[2];
            int low = 0, high = nums.Length - 1, temp = int.MinValue;

            while(low < high)
            {
                int mid = (low + high) / 2;

                if(nums[mid] == target)
                {
                    temp = Math.Min(mid, high);
                    high = temp;
                }
                else if(nums[mid] > target)
                {
                    high = mid - 1;
                }
                else if(nums[mid] < target)
                {
                    low = mid + 1;
                }
            }

            array[0] = high;

            low = high;
            high = nums.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (nums[mid] == target)
                {
                    temp = Math.Min(mid, high);
                    low = temp;
                    array[1] = low;
                   // return array;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
            }

            return array;
        }

        //private int BinarySearch(int[] nums, int target, int low, int high, int lowest)
        //{
        //    if(low < high)
        //    {
        //        int mid = (low + high) / 2;

        //        if (nums[mid] == target)
        //        {

        //            return mid;
        //        }
                    
        //        else if (nums[mid] < target) return BinarySearch(nums, target, mid, high);
        //        else if (nums[mid] > target) return BinarySearch(nums, target, low, mid);
        //    }
        //    return lowest;
        //}
    }
}
