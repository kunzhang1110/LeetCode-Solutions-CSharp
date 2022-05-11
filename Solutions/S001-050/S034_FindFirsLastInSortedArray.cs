using System;
using System.Collections.Generic;
// Time O(LogN)
/*
1. Find the target using Binary Search
2. if one before target == target
    - search left
    - else target is the smallest index
   if one after target == target
    - search right
    - else target is the largest index
*/
namespace LeetCode_Solutions_CSharp.Solution
{
    public class S034_FindFirsLastInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new int[2] { -1, -1 };
            Search(nums, target, 0, nums.Length - 1, result);
            return result;
        }

        private void Search(int[] nums, int target, int lo, int hi, int[] result)
        {
            if (lo > hi) return;
            var mid = (lo + hi) / 2;
            if (nums[mid] == target)
            {

                if (mid - 1 >= 0) //search left
                {
                    if (nums[mid] == nums[mid - 1])
                        Search(nums, target, lo, mid - 1, result);
                    else
                        result[0] = mid;
                }
                else
                    result[0] = mid;

                if (mid + 1 <= nums.Length - 1)
                { //search right
                    if (nums[mid] == nums[mid + 1])
                        Search(nums, target, mid + 1, hi, result);
                    else
                        result[1] = mid;
                }
                else
                    result[1] = mid;
            }
            else if (target > nums[mid])
            {
                Search(nums, target, mid + 1, hi, result);
            }
            else
            {
                Search(nums, target, lo, mid - 1, result);
            }
        }
    }
}

