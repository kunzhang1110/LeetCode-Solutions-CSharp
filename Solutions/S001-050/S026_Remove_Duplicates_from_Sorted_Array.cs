using System;
using System.Collections.Generic;
// Time O(N)
/* Backtracking
if (o != c)
{
    add );
    add(;
}
else
{
    add(;
}
*/

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S026_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[p])
                {
                    p++;
                    nums[p] = nums[i];
                }
            }
            return p + 1;
        }
    }
}

