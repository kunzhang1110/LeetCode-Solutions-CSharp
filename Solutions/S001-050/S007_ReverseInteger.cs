using System;
using System.Collections.Generic;
// Time O(N^2)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S007_ReverseInteger
    {

        public int Reverse(int x)
        {
            int result = 0;
            while(x !=0)
            {
                if (result > int.MaxValue / 10 || result < int.MinValue / 10) return 0;
                result = result*10 + x % 10;
                x /= 10;
            }
            return result;
        }
    }
}
