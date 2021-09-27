using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;


/*
.
.
.
.

168. Excel Sheet Column Title

Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

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

Input: columnNumber = 1
Output: "A"
Example 2:

Input: columnNumber = 28
Output: "AB"
Example 3:

Input: columnNumber = 701
Output: "ZY"
Example 4:

Input: columnNumber = 2147483647
Output: "FXSHRXW"


 */

namespace LeetCode_C_Sharp
{
    public class Problem_168: Solution 
    {
        private readonly int columnNumber;
        public Problem_168(int columnNumber) {
            this.columnNumber = columnNumber;
        }

        private string ConvertToTitle(int columnNumber)
        {
            var rtn = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                rtn = Convert.ToChar(columnNumber % 26 + 'A') + rtn;
                columnNumber /= 26;
            }
            return rtn;
        }

        public override void Do()
        {
            ConvertToTitle(this.columnNumber);
        }
    }
}
