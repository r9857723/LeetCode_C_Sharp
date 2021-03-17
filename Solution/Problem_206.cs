using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;


/*
206. Reverse Linked List

Given the head of a singly linked list, reverse the list, and return the reversed list. 

Example 1:

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []

 */

namespace LeetCode_C_Sharp
{
    public class Problem_206 : Solution
    {
        private readonly ListNode head;
        public Problem_206(ListNode head)
        {
            this.head = head;
        }

        private ListNode ReverseList(ListNode head)
        {
            if (head == null) 
                return null;

            ListNode pre = null;
            while (head != null)
            {
                var next = head.next;
                head.next = pre;
                pre = head;
                head = next;
            }
            return pre;
        }

        public override void Do()
        {
            ReverseList(this.head);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
