using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Time O(M+N)

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T036_Valide_Sudoku
    {
        [TestMethod]
        public void ValideSudokuTest_General()
        {
            var solution = new S036_Valide_Sudoku();
            var input = new char[9][]
            {
                new char[]{ '5','3','.','.','7','.','.','.','.'},
                new char[]{ '6','.','.','1','9','5','.','.','.'},
                new char[]{ '.','9','8','.','.','.','.','6','.'},
                new char[]{ '8','.','.','.','6','.','.','.','3'},
                new char[]{ '4','.','.','8','.','3','.','.','1'},
                new char[]{ '7','.','.','.','2','.','.','.','6'},
                new char[]{ '.','6','.','.','.','.','2','8','.'},
                new char[]{ '.','.','.','4','1','9','.','.','5'},
                new char[]{ '.','.','.','.','8','.','.','7','9'}
            };
            var result = solution.IsValidSudoku(input);
            Assert.IsTrue(result);
        }
    }
}
