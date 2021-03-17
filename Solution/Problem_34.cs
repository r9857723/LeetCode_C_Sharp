using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*
34. Find First and Last Position of Element in Sorted Array

Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

Follow up: Could you write an algorithm with O(log n) runtime complexity?

 

Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
Example 3:

Input: nums = [], target = 0
Output: [-1,-1]


 */

namespace LeetCode_C_Sharp
{
    public class Problem_34 : Solution 
    {

        private readonly int[] nums;
        private readonly int target;
        
        public Problem_34(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
        }

        private int[] SearchRange(int[] nums, int target)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != target)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }

                    lastIndex = i;
                }
            }
            return new int[] { firstIndex, lastIndex };
        }

        public override void Do()
        {
            SearchRange(this.nums, this.target);
        }
    }
}
