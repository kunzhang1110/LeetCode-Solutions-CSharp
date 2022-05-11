using System;
using System.Collections.Generic;
/* 
 * Time O(N)
 * Space O(1)
 */

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S048_Rotate_Image
    {
        public void Rotate(int[][] matrix)
        {
            var SIDE_LENGTH = matrix.Length;
            var SIDE_MAX = SIDE_LENGTH - 1;
            for (var i = 0; i < (SIDE_LENGTH + 1) / 2; i++)
            {
                for (var j = 0; j < SIDE_LENGTH / 2; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[SIDE_MAX - j][i];
                    matrix[SIDE_MAX - j][i] = matrix[SIDE_MAX - i][SIDE_MAX - j];
                    matrix[SIDE_MAX - i][SIDE_MAX - j] = matrix[j][SIDE_MAX - i];
                    matrix[j][SIDE_MAX - i] = temp;
                }
            }
        }
    }
}

