using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


/*
 1. Two Sum

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 */

namespace LeetCode_C_Sharp
{
    public class Problem_1: Solution 
    {
        private readonly int[] nums;
        private readonly int target;
        public Problem_1(int[] nums, int target) {
            this.nums = nums;
            this.target = target;
        }

        private int[] TwoSumSolution(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                var index = Array.IndexOf(nums, diff);
                if (index != -1)
                {
                    return new int[] { i, index };
                }
            }
            return null;
        }
        public override void Do()
        {
            TwoSumSolution(this.nums, this.target);
        }
    }
}
