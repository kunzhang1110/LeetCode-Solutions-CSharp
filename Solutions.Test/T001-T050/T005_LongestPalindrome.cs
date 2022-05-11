using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T005_LongestPalindrome
    {
        [TestMethod]
        public void LongestPalindromeTest_Simple()
        {
            var input = "babcd";

            var solution = new S005_LongestPalindrome_Manacher();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("bab", result);
        }


        [TestMethod]
        public void LongestPalindromeTest_Odd()
        {
            var input = "abcdefedcba";

            var solution = new S005_LongestPalindrome_Manacher();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefedcba", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_Even()
        {
            var input = "abcdefggfedcba";

            var solution = new S005_LongestPalindrome_Manacher();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefggfedcba", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_AllTheSame_Odd()
        {
            var input = "ccc";

            var solution = new S005_LongestPalindrome_Manacher();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("ccc", result);
        }


    }
}
