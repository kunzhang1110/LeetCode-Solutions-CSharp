using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T034_FindFirsLastInSortedArray
    {
        [TestMethod]
        public void FindFirsLastInSortedArrayTest_General()
        {
            var solution = new S034_FindFirsLastInSortedArray();
            var result = solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            AssertHelper.AssertArray(new int[] { 3, 4 }, result);
        }
    }
}
