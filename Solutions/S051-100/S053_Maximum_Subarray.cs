using System;
using System.Collections.Generic;
//Time O(M*N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S054_Spiral_Matrix

    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var M = matrix[0].Length;
            var N = matrix.Length;
            var result = new List<int>();
            int left =0, right = M - 1, top = 0, bottom = N - 1;

            while (result.Count != M * N)
            {
                for(int i = left; result.Count != M * N && i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; result.Count != M * N && i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;
                for (int i = right; result.Count != M * N && i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
                for (int i = bottom; result.Count != M * N && i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }

            return result;

        }
    }
}

