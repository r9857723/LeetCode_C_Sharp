using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*
171. Excel Sheet Column Number  


Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnTitle = "A"
Output: 1
Example 2:

Input: columnTitle = "AB"
Output: 28
Example 3:

Input: columnTitle = "ZY"
Output: 701
Example 4:

Input: columnTitle = "FXSHRXW"
Output: 2147483647
 */

namespace LeetCode_C_Sharp
{
    public class Problem_171 : Solution 
    {
        private readonly string columnTitle;
        
        public Problem_171(string columnTitle) {
            this.columnTitle = columnTitle;
        }

        private int TitleToNumber(string columnTitle)
        {
            int rtn = 0;

            for (var i = 0; i < columnTitle.Length; i++)
            {
                rtn += (Convert.ToInt32(columnTitle[i]) - 64) * Convert.ToInt32(Math.Pow(26, columnTitle.Length - i - 1));
            }


            return rtn;
        }

        public override void Do()
        {
            TitleToNumber(this.columnTitle);
        }
    }
}
