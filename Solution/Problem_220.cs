using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


/*
220. Contains Duplicate III

Given an integer array nums and two integers k and t, return true if there are two distinct indices i and j in the array such that abs(nums[i] - nums[j]) <= t and abs(i - j) <= k.

 

Example 1:

Input: nums = [1,2,3,1], k = 3, t = 0
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1, t = 2
Output: true
Example 3:

Input: nums = [1,5,9,1,5,9], k = 2, t = 3
Output: false


 */

namespace LeetCode_C_Sharp
{
    public class Problem_220 : Solution 
    {
        private readonly int[] nums;
        private readonly int k;
        private readonly int t;
        public Problem_220(int[] nums, int k, int t) {
            this.nums = nums;
            this.k = k;
            this.t = t;
        }

        private bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for (var i = 0; i < nums.Length; i++)  // 3
            {
                int start = i;//3
                int end = (i + k > nums.Length - 1) ? nums.Length - 1 : i + k;
                for(var j = start; j <= end; j++)
                {
                    if (i < j && Math.Abs((long)nums[i] - (long)nums[j]) <= t)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override void Do()
        {
            ContainsNearbyAlmostDuplicate(this.nums, this.k, this.t);
        }
    }
}
