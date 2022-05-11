using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T028_Implement_strStr
    {
        [TestMethod]
        public void ImplementstrStrTest_General1()
        {
            var solution = new S028_Implement_strStr();
            var result = solution.StrStr("hello", "ll");
            Console.WriteLine(result);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ImplementstrStrTest_General2()
        {
            var solution = new S028_Implement_strStr();
            var result = solution.StrStr("mississippi", "issipi");
            Console.WriteLine(result);
            //Assert.AreEqual(2, result);
        }
        


        [TestMethod]
        public void ImplementstrStrTest_NotFound()
        {
            var solution = new S028_Implement_strStr();
            var result = solution.StrStr("aaaaa", "bba");
            Console.WriteLine(result);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void ImplementstrStrTest_Single()
        {
            var solution = new S028_Implement_strStr();
            var result = solution.StrStr("a", "a");
            Console.WriteLine(result);
            Assert.AreEqual(0, result);
        }

    }
}
