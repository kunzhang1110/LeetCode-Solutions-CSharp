using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T020_Valid_Parentheses
    {
        [TestMethod]
        public void IsValidTest_General()
        {
            var solution = new S020_Valid_Parentheses();

            Assert.IsTrue(solution.IsValid("()"));
            Assert.IsTrue(solution.IsValid("[]"));
            Assert.IsTrue(solution.IsValid("{}"));
            Assert.IsTrue(solution.IsValid("()[]{}"));
        }

        [TestMethod]
        public void IsValidTest_NotValid()
        {
            var solution = new S020_Valid_Parentheses();

            Assert.IsFalse(solution.IsValid("("));
            Assert.IsFalse(solution.IsValid("(}"));
            Assert.IsFalse(solution.IsValid("[)"));
            Assert.IsFalse(solution.IsValid("[}"));
            Assert.IsFalse(solution.IsValid("{)"));
            Assert.IsFalse(solution.IsValid("([]){"));
        }

    }
}
