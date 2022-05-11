using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T008_StringToIntegerAtoi
    {
        [TestMethod]
        public void MyAtioTest_Simple()
        {
            var input = "42";

            var solution = new S008_StringToIntegerAtoi();
            var result = solution.MyAtoi(input);

            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void MyAtioTest_Negative()
        {
            var input = "  -42";

            var solution = new S008_StringToIntegerAtoi();
            var result = solution.MyAtoi(input);

            Assert.AreEqual(-42, result);
        }

        [TestMethod]
        public void MyAtioTest_WithWords()
        {
            var input = "  +4193 with words";

            var solution = new S008_StringToIntegerAtoi();
            var result = solution.MyAtoi(input);

            Assert.AreEqual(4193, result);
        }
        [TestMethod]
        public void MyAtioTest_Overflow()
        {
            var input = "-2147483649";

            var solution = new S008_StringToIntegerAtoi();
            var result = solution.MyAtoi(input);

            Assert.AreEqual(int.MinValue, result);
        }

    }
}
