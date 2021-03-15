using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode_C_Sharp
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 1. TwoSum
        /// </summary>
        [TestMethod]
        public void TwoSum()
        {
            TwoSum twoSum1 = new TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            twoSum1.Do();
        }

        /// <summary>
        /// 1512. NumberOfGoodPairs
        /// </summary>
        [TestMethod]
        public void NumberOfGoodPairs()
        {
            NumberOfGoodPairs numberOfGoodPairs = new NumberOfGoodPairs(new int[] { 1, 2, 3, 1, 1, 3 });
            numberOfGoodPairs.Do();
        }
    }
}
