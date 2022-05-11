using System;
using System.Collections.Generic;
//Time O(N^2)


namespace LeetCode_Solutions_CSharp.Solution
{
    public class S001_TwoSum_Loops
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == target - nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
    }
}
