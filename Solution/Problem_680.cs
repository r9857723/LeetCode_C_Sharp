using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*
680. Valid Palindrome II

Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.

Example 1:
Input: "aba"
Output: True
Example 2:
Input: "abca"
Output: True
Explanation: You could delete the character 'c'.


 */

namespace LeetCode_C_Sharp
{
    public class Problem_680 : Solution 
    {
        private readonly string s;
        public Problem_680(string s) {
            this.s = s;
        }

        private bool ValidPalindrome(string s)
        {
            int f = 0;
            int l = s.Length - 1;
            while (f < l)
            {
                if (s[f] == s[l])
                {
                    f++;
                    l--;
                } else
                {
                    return _valid(s.Substring(f + 1, l - f)) || _valid(s.Substring(f, l - f));
                }
            }
            return true;
        }

        private bool _valid(string s)
        {
            int f = 0;
            int l = s.Length - 1;
            while (f < l)
            {
                if (s[f] == s[l])
                {
                    f++;
                    l--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public override void Do()
        {
            ValidPalindrome(this.s);
        }
    }
}
