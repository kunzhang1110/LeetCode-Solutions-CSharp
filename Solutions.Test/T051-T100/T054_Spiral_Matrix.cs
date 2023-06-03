using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test.T051_T100
{

    [TestClass]
    public class T054_Spiral_Matrix
    {
        private readonly S054_Spiral_Matrix solution = new S054_Spiral_Matrix();
        public T054_Spiral_Matrix()
        {
            solution = new S054_Spiral_Matrix();
        }

        [TestMethod]
        public void SpiralMatrixTest_1()
        {
            var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var result = solution.SpiralOrder(input);
            AssertHelper.AssertList(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result);
        }

        [TestMethod]
        public void SpiralMatrixTest_2()
        {
            var input = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            var result = solution.SpiralOrder(input);
            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, result);
        }
    }
}
