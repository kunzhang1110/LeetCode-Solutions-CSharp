using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T029_Divide_Two_Integers
    {
        [TestMethod]
        public void DivideTwoIntegersTest_General()
        {
            var solution = new S029_Divide_Two_Integers();
            var result = solution.Divide(100, 4);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void DivideTwoIntegersTest_Overflow()
        {
            var solution = new S029_Divide_Two_Integers();
            var result = solution.Divide(-2147483648, -1);
            Console.WriteLine(result);
            Assert.AreEqual(int.MaxValue, result);
        }

    }
}
