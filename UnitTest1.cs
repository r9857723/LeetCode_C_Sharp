using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode_C_Sharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoSum()
        {
            TwoSum twoSum1 = new TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            twoSum1.Do();
        }
        [TestMethod]
        public void AddTwoNumbers()
        {
            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            addTwoNumbers.Do();
        }
    }
}
