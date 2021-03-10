using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


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
    public class TwoSum: Solution 
    {
        private int[] nums;
        private int target;
        public TwoSum(int[] nums, int target) {
            this.nums = nums;
            this.target = target;
        }

        private int[] TwoSumSolution(int[] nums, int target)
        {
            int[] ans = { 0, 0 };
            foreach(int num in nums)
            {
                foreach(int n in nums)
                {
                    if (num + n == target)
                    {
                        Console.WriteLine($"{num} + {n} = {target}");
                        ans[0] = num;
                        ans[1] = n;
                        return ans;
                    }
                }
            }
            throw new ArgumentException();
        }
        public override void Do()
        {
            TwoSumSolution(this.nums, this.target);
        }
    }
}
