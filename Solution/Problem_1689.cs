﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


/*
1689. Partitioning Into Minimum Number Of Deci-Binary Numbers

A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros. For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.

Given a string n that represents a positive decimal integer, return the minimum number of positive deci-binary numbers needed so that they sum up to n.

 

Example 1:

Input: n = "32"
Output: 3
Explanation: 10 + 11 + 11 = 32
Example 2:

Input: n = "82734"
Output: 8
Example 3:

Input: n = "27346209830709182346"
Output: 9


 */

namespace LeetCode_C_Sharp
{
    public class Problem_1689 : Solution 
    {
        private readonly string n;
        public Problem_1689(string n) {
            this.n = n;
        }

        private int MinPartitions(string n)
        {
            return n.ToCharArray().Max() - '0';
        }

        public override void Do()
        {
            MinPartitions(this.n);
        }
    }
}
