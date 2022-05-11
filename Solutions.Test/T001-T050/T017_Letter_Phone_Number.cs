using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T017_Letter_Phone_Number
    {
        [TestMethod]
        public void LetterCombinationsTest_WithSeven()
        {
            var solution = new S017_Letter_Phone_Number();
            var result = solution.LetterCombinations("27");

            Assert.AreEqual(12, result.Count);
            Assert.IsTrue(result.Contains("ap"));
            Assert.IsTrue(result.Contains("aq"));
            Assert.IsTrue(result.Contains("ar"));
            Assert.IsTrue(result.Contains("as"));
            Assert.IsTrue(result.Contains("bp"));
            Assert.IsTrue(result.Contains("bq"));
            Assert.IsTrue(result.Contains("br"));
            Assert.IsTrue(result.Contains("bs"));
            Assert.IsTrue(result.Contains("cp"));
            Assert.IsTrue(result.Contains("cq"));
            Assert.IsTrue(result.Contains("cr"));
            Assert.IsTrue(result.Contains("cs"));
        }

        [TestMethod]
        public void LetterCombinationsTest_WithNine()
        {
            var solution = new S017_Letter_Phone_Number();
            var result = solution.LetterCombinations("27");

            result = solution.LetterCombinations("29");
            Assert.AreEqual(12, result.Count);
            Assert.IsTrue(result.Contains("aw"));
            Assert.IsTrue(result.Contains("ax"));
            Assert.IsTrue(result.Contains("ay"));
            Assert.IsTrue(result.Contains("az"));
            Assert.IsTrue(result.Contains("bw"));
            Assert.IsTrue(result.Contains("bx"));
            Assert.IsTrue(result.Contains("by"));
            Assert.IsTrue(result.Contains("bz"));
            Assert.IsTrue(result.Contains("cw"));
            Assert.IsTrue(result.Contains("cx"));
            Assert.IsTrue(result.Contains("cy"));
            Assert.IsTrue(result.Contains("cz"));
        }



    }
}
