using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
66. Plus One


Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Example 3:

Input: digits = [0]
Output: [1]


 */

namespace LeetCode_C_Sharp
{
    public class Problem_66 : Solution 
    {
        private readonly int[] digits;

        public Problem_66(int[] digits) {
            this.digits = digits;
        }

        private int[] PlusOne(int[] digits)
        {
            var rtn = new List<int>();
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--) 
            {
                int n = digits[i] + carry;
                carry = n / 10;
                rtn.Add(n % 10);
            }
            if (carry != 0)
            {
                rtn.Add(carry);
            }
            rtn.Reverse();
            return rtn.ToArray(); 
        }

        public override void Do()
        {
            PlusOne(this.digits);
        }
    }
}
