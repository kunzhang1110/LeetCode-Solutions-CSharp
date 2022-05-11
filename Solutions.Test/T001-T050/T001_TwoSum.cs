using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T001_TwoSum
    {
        [TestMethod]
        public void TwoSum_Dict_Ordered()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var solution = new S001_TwoSum_Dict();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TwoSum_Loops_Ordered()
        {
            var nums = new int[] { 5, 34, 15, 30 };
            var target = 20;

            var solution = new S001_TwoSum_Loops();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}
