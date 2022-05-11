using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T014_Longest_Common_Prefix
    {
        [TestMethod]
        public void LongestCommonPrefixTest_Simple()
        {
            var solution = new S014_Longest_Common_Prefix();

            var result = solution.LongestCommonPrefix(new string[2] { "aa", "a" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new string[2] { "a", "aa" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new string[3] { "abcd", "abc", "abd" });
            Assert.AreEqual("ab", result);
        }





    }
}
