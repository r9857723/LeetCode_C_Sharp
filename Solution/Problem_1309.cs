using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;


/*
1309. Decrypt String from Alphabet to Integer Mapping
Given a string s formed by digits ('0' - '9') and '#' . We want to map s to English lowercase characters as follows:

Characters ('a' to 'i') are represented by ('1' to '9') respectively.
Characters ('j' to 'z') are represented by ('10#' to '26#') respectively. 
Return the string formed after mapping.

It's guaranteed that a unique mapping will always exist.

 

Example 1:

Input: s = "10#11#12"
Output: "jkab"
Explanation: "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".
Example 2:

Input: s = "1326#"
Output: "acz"
Example 3:

Input: s = "25#"
Output: "y"
Example 4:

Input: s = "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#"
Output: "abcdefghijklmnopqrstuvwxyz"

 */

namespace LeetCode_C_Sharp
{
    public class Problem_1309 : Solution 
    {
        private readonly string s;
        public Problem_1309(string s) {
            this.s = s;
        }

        private string Solution(string s)
        {
            var sb = new StringBuilder();
            for(var i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 2 && s[i + 2] == '#') 
                {
                    var a = int.Parse(s.Substring(i, 2));
                    sb.Append((char)('a' + a - 1));
                    i = i+ 2;
                } else
                {
                    sb.Append((char)('a' + s[i] - '0' - 1));
                }
            }
            return sb.ToString();
        }

        public override void Do()
        {
            Solution(this.s);
        }
    }
}
