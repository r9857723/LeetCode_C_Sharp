using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


/*
217. Contains Duplicate

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true


 */

namespace LeetCode_C_Sharp
{
    public class Problem_217 : Solution 
    {
        private readonly int[] nums;

        public Problem_217(int[] nums) {
            this.nums = nums;
        }

        private bool ContainsDuplicate(int[] nums)
        {
            //var list = nums.GroupBy(x => x).ToDictionary(x => x.Key, y => y.ToList());
            //return list.Where(x => x.Value.Count > 1).Count() > 0;

            return nums.Length != new HashSet<int>(nums).Count();
        }

        public override void Do()
        {
            ContainsDuplicate(this.nums);
        }
    }
}
