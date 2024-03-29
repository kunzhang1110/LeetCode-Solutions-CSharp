﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T046_Permutations
    {
        [TestMethod]
        public void PermuteTest()
        {
            var input = new int[] { 1, 2, 3 };

            var solution = new S046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(6, result.Count);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 },
            }, result);
        }

        [TestMethod]
        public void PermuteTest_2()
        {
            var input = new int[] { 1, 2, 3, 4 };

            var solution = new S046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(24, result.Count);
        }

        [TestMethod]
        public void PermuteTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new S046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(1, result.Count);
        }
    }
}
