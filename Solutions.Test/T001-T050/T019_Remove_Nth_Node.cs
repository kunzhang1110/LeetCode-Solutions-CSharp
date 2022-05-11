using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T019_Remove_Nth_Node
    {
        [TestMethod]
        public void RemoveNthTest_General()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new S019_Remove_Nth_Node_From_End();
            var result = solution.RemoveNthFromEnd(input, 2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 5 }, result);
        }

        [TestMethod]
        public void RemoveNthTest_SingleInput()
        {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new S019_Remove_Nth_Node_From_End();
            var result = solution.RemoveNthFromEnd(input, 1);

            Assert.IsNull(result);
        }

    }
}
