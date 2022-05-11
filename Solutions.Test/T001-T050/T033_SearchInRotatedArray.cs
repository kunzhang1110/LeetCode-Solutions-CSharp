using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T033_SearchInRotatedArray
    {
        [TestMethod]
        public void SearchInRotatedArray_General()
        {
            var solution = new S033_SearchInRotatedArray();
            var result = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Assert.AreEqual(4, result);
        }
    }
}
