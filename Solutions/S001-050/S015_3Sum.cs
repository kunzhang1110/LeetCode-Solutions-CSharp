using System;
using System.Collections.Generic;
// Time O(N^2)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S015_3Sum
    {

     
        public IList<IList<int>> ThreeSum(int[] nums)
        {
           

            var result = new List<IList<int>>();
            if (nums.Length < 3) return result;

            Array.Sort(nums);

            //use two pointers traversing from start and end
            for(int i = 0; i < nums.Length-2; i++)
            {
                int lo = i+1;
                int hi = nums.Length - 1;
                  
                //skip all duplicates from left
                if(i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                while (lo < hi)
                {
                    int sum = nums[i] + nums[lo] + nums[hi];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[lo], nums[hi]});
                        hi--;
                        while (lo < hi && nums[hi] == nums[hi + 1]) hi--; //skip duplicates from right
                    }else if (sum > 0)
                    {
                        hi--;
                    }
                    else
                    {
                        lo++;
                    }
                }
            }
            return result;
        }
         
    }
}
