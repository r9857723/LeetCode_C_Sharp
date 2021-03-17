using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


/*
1784. Check if Binary String Has at Most One Segment of Ones

Given a binary string s ​​​​​without leading zeros, return true​​​ if s contains at most one contiguous segment of ones. Otherwise, return false. 

Example 1:

Input: s = "1001"
Output: false
Explanation: The ones do not form a contiguous segment.
Example 2:

Input: s = "110"
Output: true

 */

namespace LeetCode_C_Sharp
{
    public class Problem_1784 : Solution 
    {
        private readonly string s;

        public Problem_1784(string s) {
            this.s = s;
        }

        private bool CheckOnesSegment(string s)
        {
            for (int i = 1; i < s.Length; ++i)
            {
                if (s[i - 1] == '0' && s[i] == '1') 
                    return false;
            }
            return true;
        }

        public override void Do()
        {
            CheckOnesSegment(this.s);
        }
    }
}
