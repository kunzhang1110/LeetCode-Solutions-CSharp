using System;
using System.Collections.Generic;
// Time O(N^2)
/*
- one hashset for rows two dictionary for columns and blocks
- subblocks are assigned as
    0 1 2
    3 4 5
    6 7 8
- block indexs are calculated by :  blkIdx = 3 * (row / 3) + col/ 3;
*/
namespace LeetCode_Solutions_CSharp.Solution
{
    public class S036_Valide_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rowSet = new HashSet<char>();
            var colDic= InitializeDic();
            var blockDic = InitializeDic();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if(board[row][col] != '.')
                    {
                        var number = board[row][col];
                        int blkIdx = 3 * (row / 3) + col/ 3;//blck index
                        Console.WriteLine($"{blkIdx}  {row}   {col}");
                        if (rowSet.Contains(number)) return false;
                        if (colDic[col].Contains(number)) return false;
                        if (blockDic[blkIdx].Contains(number)) return false;
                        rowSet.Add(number);
                        colDic[col].Add(number);
                        blockDic[blkIdx].Add(number);
                    }
                }
                rowSet.Clear();
            }
            return true;

        }

        private Dictionary<int, HashSet<char>> InitializeDic()
        {
            var dic = new Dictionary<int, HashSet<char>>();
            for(int i = 0; i<10; i++) dic.Add(i, new HashSet<char>()); 
            return dic;
        }

    }
}

