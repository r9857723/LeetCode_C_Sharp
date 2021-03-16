using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode_C_Sharp
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 1. Two Sum
        /// </summary>
        [TestMethod]
        public void Problem_1()
        {
            Problem_1 problem_1 = new Problem_1(new int[] { 2, 7, 11, 15 }, 9);
            problem_1.Do();
        }

        /// <summary>
        /// 1309. Decrypt String from Alphabet to Integer Mapping
        /// </summary>
        [TestMethod]
        public void Problem_1309()
        {
            Problem_1309 problem_1309 = new Problem_1309("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#");
            problem_1309.Do();
        }

        /// <summary>
        /// 1342. Number of Steps to Reduce a Number to Zero
        /// </summary>
        [TestMethod]
        public void Problem_1342()
        {
            Problem_1342 problem_1342 = new Problem_1342(14);
            problem_1342.Do();
        }

        /// <summary>
        /// 1512. Number Of Good Pairs
        /// </summary>
        [TestMethod]
        public void Problem_1512()
        {
            Problem_1512 problem_1512 = new Problem_1512(new int[] { 1, 2, 3, 1, 1, 3 });
            problem_1512.Do();
        }

        /// <summary>
        /// 1480. Running Sum of 1d Array
        /// </summary>
        [TestMethod]
        public void Problem_1480() {
            Problem_1480 problem_1480 = new Problem_1480(new int[] { 3, 1, 2, 10, 1 });
            problem_1480.Do();
        }

        /// <summary>
        /// 1784. Check if Binary String Has at Most One Segment of Ones
        /// </summary>
        [TestMethod]
        public void Problem_1784()
        {
            Problem_1784 problem_1784 = new Problem_1784("1001");
            problem_1784.Do();
        }
    }
}
