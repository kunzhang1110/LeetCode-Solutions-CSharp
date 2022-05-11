using System;
using System.Collections.Generic;
/* 
 * Time O(log(N))
 * Space O(log(N))
 */
//Binary tree multiplication

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S053_Maximum_Subarray

    {
        public int MaxSubArray(int[] nums)
        {
            int global_max = int.MinValue;
            int local_max = 0;
            int length = nums.Length;


            for (int i = 0; i < length; i++)
            {
                local_max = Math.Max(nums[i], nums[i] + local_max);
                if (local_max > global_max)
                    global_max = local_max;
            }
            return global_max;
        }
    }
}

