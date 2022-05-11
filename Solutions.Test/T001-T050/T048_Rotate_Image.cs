using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T048_Rotate_Image
    {
        [TestMethod]
        public void RotateTest()
        {
            var input = new int[3][] {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5, 6},
                new int[]{ 7, 8, 9},
            };

            var solution = new S048_Rotate_Image();
            solution.Rotate(input);

            AssertHelper.AssertArray(
                new int[3][] {
                new int[]{ 7,4,1},
                new int[]{ 8,5,2},
                new int[]{ 9,6,3},
            }, input);
        }





    }
}
