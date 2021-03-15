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

        [TestMethod]
        public void Problem_1784()
        {
            Problem_1784 problem_1784 = new Problem_1784("1001");
            problem_1784.Do();
        }
    }
}
