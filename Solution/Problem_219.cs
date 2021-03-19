using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


/*
219. Contains Duplicate II

Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k. 

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false


 */

namespace LeetCode_C_Sharp
{
    public class Problem_219 : Solution 
    {
        private readonly int[] nums;
        private readonly int k;
        public Problem_219(int[] nums, int k) {
            this.nums = nums;
            this.k = k;
        }

        private bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> con = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                int n = nums[i];
                if (con.ContainsKey(n))
                {
                    if (i - con[n] <= k) 
                    {
                        return true;
                    }
                }
                con[n] = i;
            }
            return false;
        }

        public override void Do()
        {
            ContainsNearbyDuplicate(this.nums, this.k);
        }
    }
}
