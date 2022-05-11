using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T003_LongestSubString
    {
        [TestMethod]
        public void LengthOfLongestSubstringTest()
        {
            var input = "abcabcbb";

            var solution = new S003_LongestSubString();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstringTest_RepeatChars()
        {
            var input = "bbbbb";

            var solution = new S003_LongestSubString();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstringTest_LongString()
        {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            var solution = new S003_LongestSubString();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(26, result);
        }
    }
}
