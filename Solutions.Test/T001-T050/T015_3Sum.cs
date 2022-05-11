using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T015_3Sum
    {
        [TestMethod]
        public void ThreeSumTest_Simple()
        {
            var solution = new S015_3Sum();

            var result = solution.ThreeSum(new int[6] {-1, 0, 1, 2, -1, -4});
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            }, result);
        }

        [TestMethod]
        public void ThreeSumTest_AllSame()
        {
            var solution = new S015_3Sum();

            var result = solution.ThreeSum(new int[4] {0,0,0, 0});
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0,0,0 },
            }, result);
        }
    }
}
