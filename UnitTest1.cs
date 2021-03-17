using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode_C_Sharp
{
    [TestClass]
    public class UnitTest1
    {
        #region
        [TestMethod]
        public void Problem_Example()
        {
            Assert.IsTrue(true);
        }
        #endregion

        #region 1. Two Sum
        [TestMethod]
        public void Problem_1()
        {
            Problem_1 problem_1 = new Problem_1(new int[] { 2, 7, 11, 15 }, 9);
            problem_1.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 34. Find First and Last Position of Element in Sorted Array
        [TestMethod]
        public void Problem_34()
        {
            Problem_34 problem_34 = new Problem_34(new int[] { 1 }, 1);
            problem_34.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 206. Reverse Linked List
        [TestMethod]
        public void Problem_206()
        {
            ListNode ln1 = new ListNode(1);
            ListNode ln2 = new ListNode(2);
            ListNode ln3 = new ListNode(3);
            ListNode ln4 = new ListNode(4);
            ListNode ln5 = new ListNode(5);
            ln1.next = ln2;
            ln2.next = ln3;
            ln3.next = ln4;
            ln4.next = ln5;
            ln5.next = null;

            Problem_206 problem_206 = new Problem_206(ln1);
            problem_206.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 171. Excel Sheet Column Number
        [TestMethod]
        public void Problem_171()
        {
            Problem_171 problem_171 = new Problem_171("FXSHRXW");
            problem_171.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 1309. Decrypt String from Alphabet to Integer Mapping
        [TestMethod]
        public void Problem_1309()
        {
            Problem_1309 problem_1309 = new Problem_1309("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#");
            problem_1309.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 1342. Number of Steps to Reduce a Number to Zero
        [TestMethod]
        public void Problem_1342()
        {
            Problem_1342 problem_1342 = new Problem_1342(14);
            problem_1342.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 1512. Number Of Good Pairs
        [TestMethod]
        public void Problem_1512()
        {
            Problem_1512 problem_1512 = new Problem_1512(new int[] { 1, 2, 3, 1, 1, 3 });
            problem_1512.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 1480. Running Sum of 1d Array
        [TestMethod]
        public void Problem_1480() {
            Problem_1480 problem_1480 = new Problem_1480(new int[] { 3, 1, 2, 10, 1 });
            problem_1480.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 1784. Check if Binary String Has at Most One Segment of Ones
        [TestMethod]
        public void Problem_1784()
        {
            Problem_1784 problem_1784 = new Problem_1784("1001");
            problem_1784.Do();
            Assert.IsTrue(true);
        }
        #endregion
    }
}
