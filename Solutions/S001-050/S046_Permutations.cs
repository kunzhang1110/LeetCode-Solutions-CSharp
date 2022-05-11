using System;
using System.Collections.Generic;
/* Time O(N!)
 */

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S046_Permutations
    {
        List<IList<int>> results = new List<IList<int>>();

        public void GetPermutation(List<int> list, List<int> result)
        {


            if (list.Count == 1)
            {
                result.Add(list[0]);
                results.Add(result);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var new_list = new List<int>(list);
                    new_list.Remove(list[i]);
                    var new_result = new List<int>(result);
                    new_result.Add(list[i]);
                    GetPermutation(new_list, new_result);
                }
            }

        }

        public IList<IList<int>> Permute(int[] nums)
        {
            GetPermutation(new List<int>(nums), new List<int>() { });
            return results;

        }
    }
}

