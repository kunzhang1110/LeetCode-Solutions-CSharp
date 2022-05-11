using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T007_ReverseInteger
    {
        [TestMethod]
        public void ReverseIntegerTest_Simple()
        {
            var input = -123;

            var solution = new S007_ReverseInteger();
            var result = solution.Reverse(input);

            Assert.AreEqual(-321, result);
        }

        [TestMethod]
        public void ReverseIntegerTest_DifferentDigits()
        {
            var input = -120;

            var solution = new S007_ReverseInteger();
            var result = solution.Reverse(input);

            Assert.AreEqual(-21, result);
        }
    }
}
