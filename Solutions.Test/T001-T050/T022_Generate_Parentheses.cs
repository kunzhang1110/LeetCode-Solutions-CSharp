using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T022_Generate_Parentheses
    {
        [TestMethod]
        public void GenerateParenthesisTest_General()
        {
            var solution = new S022_Generate_Parentheses();
            var result = solution.GenerateParenthesis(3);

            Assert.AreEqual(5, result.Count);
            Assert.AreEqual("((()))", result[0]);
            Assert.AreEqual("(()())", result[1]);
            Assert.AreEqual("(())()", result[2]);
            Assert.AreEqual("()(())", result[3]);
            Assert.AreEqual("()()()", result[4]);
        }

        [TestMethod]
        public void GenerateParenthesisTest_LargeN()
        {
            var solution = new S022_Generate_Parentheses();
            var result = solution.GenerateParenthesis(4);
            Assert.AreEqual(14, result.Count);
            result = solution.GenerateParenthesis(5);
            Assert.AreEqual(42, result.Count);
            result = solution.GenerateParenthesis(6);
            Assert.AreEqual(132, result.Count);
        }

    }
}
