using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T013_Roman_to_Integer
    {
        [TestMethod]
        public void RomanToIntegerTest_Simple()
        {
            var solution = new S013_Roman_to_Integer();

            var result = solution.RomanToInt("XC");
            Assert.AreEqual(90, result);

            result = solution.RomanToInt("V");
            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void RomanToIntTest_Complex()
        {
            var solution = new S013_Roman_to_Integer();

            var result = solution.RomanToInt("DCCXLIV");
            Assert.AreEqual(744, result);

            result = solution.RomanToInt("MMCDXCIV");
            Assert.AreEqual(2494, result);
        }

    }
}
