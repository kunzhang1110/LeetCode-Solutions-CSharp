//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCode_Solutions_CSharp.Solution.Test
//{

//    [TestClass]
//    public class T004_MedianOfTwoArrays
//    {
//        [TestMethod]
//        public void FindMedianSortedArraysTest_Nums2SingleItem_Even()
//        {
//            int[] nums1 = { 2, 3, 4, 5, 6 };
//            int[] nums2 = { 1 };

//            var solution = new S004_MedianOfTwoArrays();
//            var result = solution.FindMedianSortedArrays(nums1, nums2);

//            Assert.AreEqual(3.5, result);
//        }

//        [TestMethod]
//        public void FindMedianSortedArraysTest_Nums1SingleItem_Odd()
//        {
//            int[] nums1 = { 1 };
//            int[] nums2 = { 2, 3, 4, 5, 6, 7 };

//            var solution = new S004_MedianOfTwoArrays();
//            var result = solution.FindMedianSortedArrays(nums1, nums2);

//            Assert.AreEqual(4, result);
//        }

//        [TestMethod]
//        public void FindMedianSortedArraysTest_MixedArray()
//        {
//            int[] nums1 = { 2 };
//            int[] nums2 = { 1, 3, 4 };

//            var solution = new S004_MedianOfTwoArrays();
//            var result = solution.FindMedianSortedArrays(nums1, nums2);

//            Assert.AreEqual(2.5, result);
//        }

//    }
//}
