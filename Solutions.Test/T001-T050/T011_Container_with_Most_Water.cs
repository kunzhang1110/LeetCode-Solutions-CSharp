using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T011_Container_with_Most_Water
    {
        [TestMethod]
        public void ContainerWithMostWaterTest_Simple()
        {
            var input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var solution = new S011_Container_with_Most_Water();
            var result = solution.MaxArea(input);

            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void MaxAreaTest_Same_Height()
        {
            int[] input = { 1, 1 };

            var solution = new S011_Container_with_Most_Water();
            var result = solution.MaxArea(input);

            Assert.AreEqual(1, result);
        }
    }
}
