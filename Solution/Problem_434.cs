using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


/*
434. Number of Segments in a String

You are given a string s, return the number of segments in the string. 

A segment is defined to be a contiguous sequence of non-space characters.

 

Example 1:

Input: s = "Hello, my name is John"
Output: 5
Explanation: The five segments are ["Hello,", "my", "name", "is", "John"]
Example 2:

Input: s = "Hello"
Output: 1
Example 3:

Input: s = "love live! mu'sic forever"
Output: 4
Example 4:

Input: s = ""
Output: 0


 */

namespace LeetCode_C_Sharp
{
    public class Problem_434 : Solution 
    {
        private readonly string s;

        public Problem_434(string s) {
            this.s = s;
        }

        private int CountSegments(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            var rtn = s.Split(' ');
            return rtn.Where(x => !string.IsNullOrWhiteSpace(x)).Count();
        }

        public override void Do()
        {
            CountSegments(this.s);
        }
    }
}
