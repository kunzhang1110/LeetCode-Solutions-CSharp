using System;
using System.Collections.Generic;
//Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S001_TwoSum_Dict
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)       //O(n)
            {

                if (numsDictionary.ContainsKey(nums[i]))  //O(1)
                {
                    return new int[] { numsDictionary[nums[i]], i };
                }
                else
                {
                    numsDictionary[target - nums[i]] = i; //O(1)
                }
            }
            return new int[] { };
        }


    }
}
