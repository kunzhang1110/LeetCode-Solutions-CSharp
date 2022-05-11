using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T002_AddTwoNumbers
    {
        [TestMethod]
        public void AddTwoNumbersTest_NoCarry ()
        {
            var link = TestHelper.GenerateList(new int[] { 2, 4, 3 });

            var solution = new S002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 4, 8, 6 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new S002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasMultipleCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1 });
            var link2 = TestHelper.GenerateList(new int[] { 9, 9 });

            var solution = new S002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 0, 0, 1 }, result);
        }
    }
}
