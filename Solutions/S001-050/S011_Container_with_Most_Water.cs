using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S011_Container_with_Most_Water
    {

        public int MaxArea(int[] height)
        {
            var n = height.Length;
            var i = 0;
            var j = n-1;
            var maxArea = 0;
            while (j - i > 0)
            {
                var area = (j - i) * Math.Min(height[i], height[j]);
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if (height[i]<height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }

            }
            return maxArea;
        }

    }
}
