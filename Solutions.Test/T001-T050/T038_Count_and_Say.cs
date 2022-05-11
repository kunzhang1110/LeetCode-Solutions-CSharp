using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T038_Count_and_Say
    {
        [TestMethod]
        public void CountAndSayTest_General()
        {
            var solution = new S038_Count_and_Say();
            var result = solution.CountAndSay(4);
            Assert.AreEqual("1211", result);
        }
    }
}
