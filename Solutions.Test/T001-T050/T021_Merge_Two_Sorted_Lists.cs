using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T021_Merge_Two_Sorted_Lists
    {
        [TestMethod]
        public void MergeTwoListsTest()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_Single()
        {
            var list1 = TestHelper.GenerateList(new int[] { 2});
            var list2 = TestHelper.GenerateList(new int[] { 1});

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2}, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9, 11, 13 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 }, result);
        }
        [TestMethod]
        public void MergeTwoListsTest_List2Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10, 12, 14 });

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Empty()
        {
            var list2 = TestHelper.GenerateList(new int[] { -5, 1 });

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(null, list2);

            AssertHelper.AssertLinkList(new int[] { -5, 1}, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List2Empty()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });

            var solution = new S021_Merge_Two_Sorted_Lists();
            var result = solution.MergeTwoLists(list1, null);

            AssertHelper.AssertLinkList(new int[] { 1, 3, 5, 7, 9 }, result);

        }
    }
}
