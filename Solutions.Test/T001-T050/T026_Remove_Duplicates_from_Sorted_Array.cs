using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T026_Remove_Duplicates_from_Sorted_Array
    {
        [TestMethod]
        public void RemoveDuplicatesTest_General()
        {
            var solution = new S026_Remove_Duplicates_from_Sorted_Array();
            var input = new int[] { 0,1, 2, 3, 4, 4 };
            var result = solution.RemoveDuplicates(input);
            Console.WriteLine(result);
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        [TestMethod]
        public void RemoveDuplicatesTest_General2()
        {
            var solution = new S026_Remove_Duplicates_from_Sorted_Array();
            var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = solution.RemoveDuplicates(input);
            Console.WriteLine(result);
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        [TestMethod]
        public void RemoveDuplicatesTest_Short()
        {
            var solution = new S026_Remove_Duplicates_from_Sorted_Array();
            var input = new int[] { 1, 2};
            var result = solution.RemoveDuplicates(input);
            Console.WriteLine(result);
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }


        [TestMethod]
        public void RemoveDuplicatesTest_Short2()
        {
            var solution = new S026_Remove_Duplicates_from_Sorted_Array();
            var input = new int[] { 1, 1, 1};
            var result = solution.RemoveDuplicates(input);
            Console.WriteLine(result);
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }
    }
}
