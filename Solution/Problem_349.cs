using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

/*

349. Intersection of Two Arrays

Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.

 */

namespace LeetCode_C_Sharp
{
    public class Problem_349 : Solution 
    {
        private readonly int[] num1;
        private readonly int[] num2;
        public Problem_349(int[] num1, int[] num2) {
            this.num1 = num1;
            this.num2 = num2;
        }

        private int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums2.Where(x => nums1.ToHashSet().Contains(x)).Distinct().ToArray();
        }

        public override void Do()
        {
            Intersection(this.num1, this.num2);
        }
    }
}
