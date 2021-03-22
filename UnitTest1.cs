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

        #region 66. Plus One
        [TestMethod]
        public void Problem_66()
        {
            //Problem_66 problem_66 = new Problem_66(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 });
            Problem_66 problem_66 = new Problem_66(new int[] { 9 });
            problem_66.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 151. Reverse Words in a String
        [TestMethod]
        public void Problem_151()
        {
            Problem_151 problem_151 = new Problem_151("  Bob    Loves  Alice   ");
            problem_151.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 168. Excel Sheet Column Title
        [TestMethod]
        public void Problem_168()
        {
            Problem_168 problem_168 = new Problem_168(2147483647);
            problem_168.Do();
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

        #region 217. Contains Duplicate
        [TestMethod]
        public void Problem_217()
        {
            Problem_217 problem_217 = new Problem_217(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
            problem_217.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 219. Contains Duplicate II
        [TestMethod]
        public void Problem_219()
        {
            Problem_219 problem_219 = new Problem_219(new int[] { 1, 2, 3, 1 }, 3);
            problem_219.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 220. Contains Duplicate III  (XXXXXXX)
        [TestMethod]
        public void Problem_220()
        {
            //Problem_220 problem_220 = new Problem_220(new int[] { 1, 2, 3, 1 }, 3, 0);
            Problem_220 problem_220 = new Problem_220(new int[] { -3, 3, -6 }, 10000, 0);
            problem_220.Do();

            Assert.IsTrue(true);
        }
        #endregion

        #region 434. Number of Segments in a String
        [TestMethod]
        public void Problem_434()
        {
            Problem_434 problem_434 = new Problem_434("Of all the gin joints in all the towns in all the world,   ");
            problem_434.Do();
            Assert.IsTrue(true);
        }
        #endregion

        #region 680. Valid Palindrome II
        [TestMethod]
        public void Problem_608()
        {
            Problem_680 problem_680 = new Problem_680("abc");
            problem_680.Do();
            Assert.IsTrue(true);
        }
        #endregion 

        #region 1154. Day of the Year
        [TestMethod] 
        public void Problem_1154()
        {
            Problem_1154 problem_1154 = new Problem_1154("2019-01-09");
            problem_1154.Do();
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

        #region 1689. Partitioning Into Minimum Number Of Deci-Binary Numbers
        [TestMethod]
        public void Problem_1689()
        {
            Problem_1689 problem_1689 = new Problem_1689("32");
            problem_1689.Do();
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
