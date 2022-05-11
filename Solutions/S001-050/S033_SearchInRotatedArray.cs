using System;
using System.Collections.Generic;
// Time O(LogN)
/*
If right section is sorted and target on right
    - search right
    - else searh left
If left section is sorted, and target on left; 
    - search left
    - else search right
*/
namespace LeetCode_Solutions_CSharp.Solution
{
    public class S033_SearchInRotatedArray
    {
        public int Search(int[] nums, int target)
        {
            return RotateSearch(nums, target, 0, nums.Length - 1); ;
        }

        public int RotateSearch(int[] nums, int target, int low, int high)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (target == nums[mid]) return mid;
            if (target == nums[low]) return low;
            if (target == nums[high]) return high;
            if (nums[mid] < nums[high] && nums[high] < nums[low])
            { //sorted on Right
                if (target > nums[mid] && target < nums[high]) //target on Right
                    return RotateSearch(nums, target, mid + 1, high); //search right
                else
                    return RotateSearch(nums, target, low, mid - 1); //search left
            }
            else //sorted on left
            {
                if (target < nums[mid] && target > nums[low]) //target on left
                    return RotateSearch(nums, target, low, mid - 1);//search left
                else
                    return RotateSearch(nums, target, mid + 1, high);//search right
            }
        }
        //public int RotateSearch(int[] nums, int target, int low, int high)
        //{
        //    if (low > high) return -1;
        //    int mid = (low + high) / 2;
        //    if (target == nums[mid]) return mid;
        //    if (target == nums[low]) return low;
        //    if (target == nums[high]) return high;
        //    if ((nums[mid] < target && target < nums[high] && nums[high] < nums[low]) ||
        //       ((nums[high] < nums[mid] || nums[low] < nums[high]) && (nums[mid] < target || target < nums[low])))
        //        return RotateSearch(nums, target, mid + 1, high); //search right
        //    else return RotateSearch(nums, target, low, mid - 1);//search left
        //}
    }
}

