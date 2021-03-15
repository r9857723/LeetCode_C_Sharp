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
        public void _1_TwoSum()
        {
            TwoSum twoSum1 = new TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            twoSum1.Do();
        }

        /// <summary>
        /// 1512. Number Of Good Pairs
        /// </summary>
        [TestMethod]
        public void _1512_NumberOfGoodPairs()
        {
            NumberOfGoodPairs numberOfGoodPairs = new NumberOfGoodPairs(new int[] { 1, 2, 3, 1, 1, 3 });
            numberOfGoodPairs.Do();
        }

        /// <summary>
        /// 1480. Running Sum of 1d Array
        /// </summary>
        [TestMethod]
        public void _1480_RunningSumOf1dArray() {
            RunningSumOf1dArray runningSumOf1dArray = new RunningSumOf1dArray(new int[] { 3, 1, 2, 10, 1 });
            runningSumOf1dArray.Do();
        }
    }
}
