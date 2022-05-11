using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T050_Pow
    {
        [TestMethod]
        public void MyPowTest_XLargerThanZero_NLargerThanZero()
        {
            var solution = new S050_Pow();
            var result = solution.MyPow(5, 1);
            Assert.AreEqual(5, result);

            result = solution.MyPow(2, 5);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void MyPowTest_XLargerThanZero_NLessThanZero()
        {
            var solution = new S050_Pow();
            var result = solution.MyPow(5, -1);
            Assert.AreEqual(0.2, result);

            result = solution.MyPow(2, -5);
            Assert.AreEqual(0.03125, result);
        }

        [TestMethod]
        public void MyPowTest_XLessThanZero_NLargerThanZero()
        {
            var solution = new S050_Pow();
            var result = solution.MyPow(-5, 1);
            Assert.AreEqual(-5, result);

            result = solution.MyPow(-2, 5);
            Assert.AreEqual(-32, result);

            result = solution.MyPow(-2, 6);
            Assert.AreEqual(64, result);
        }

        [TestMethod]
        public void MyPowTest_XLessThanZero_NLessThanZero()
        {
            var solution = new S050_Pow();
            var result = solution.MyPow(-5, -1);
            Assert.AreEqual(-0.2, result);

            result = solution.MyPow(-2, -5);
            Assert.AreEqual(-0.03125, result);

            result = solution.MyPow(-2, -6);
            Assert.AreEqual(0.015625, result);
        }

        [TestMethod]
        public void MyPowTest_LargeN()
        {
            var solution = new S050_Pow();
            var result = solution.MyPow(2.0, -2147483648);
            Assert.AreEqual(0, result);
        }

    }
}
