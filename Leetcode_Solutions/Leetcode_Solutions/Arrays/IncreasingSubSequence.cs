﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Arrays
{ 
    class IncreasingSubSequence
    {
        /*
          Given an unsorted array return whether an increasing subsequence of length 3 exists or not in the array.

        Formally the function should:

            Return true if there exists i, j, k
            such that arr[i] < arr[j] < arr[k] given 0 ≤ i < j < k ≤ n-1 else return false. 

            Your algorithm should run in O(n) time complexity and O(1) space complexity.

            Examples:
            Given [1, 2, 3, 4, 5],
            return true.

            Given [5, 4, 3, 2, 1],
            return false. 
             */
        public Boolean IncreaseSubSequence(int[] nums)
        {
            int small = int.MaxValue;
            int big = int.MaxValue;

            foreach(int n in nums)
            {
                if (n <= small) small = n;
                else if (n <= big) big = n;
                else return true;
            }
            return false;
        }
    }
}
