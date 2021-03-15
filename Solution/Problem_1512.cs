using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*
1512. Number of Good Pairs

Given an array of integers nums.

A pair (i,j) is called good if nums[i] == nums[j] and i < j.

Return the number of good pairs.

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.
Example 3:

Input: nums = [1,2,3]
Output: 0
 */

namespace LeetCode_C_Sharp
{
    public class Problem_1512: Solution 
    {
        private readonly int[] nums;
        public Problem_1512(int[] nums) {
            this.nums = nums;
        }

        private int NumIdenticalPairsSolution(int[] nums)
        {
            int count = 0;

            for(var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i< j)
                    {
                        count++;
                    }
                }                
            }
            return count;
        }

        public override void Do()
        {
            NumIdenticalPairsSolution(this.nums);

        }
    }
}
