using System;
using System.Collections.Generic;
// Time O(N)
/*
Depths firt search
We want to get: 100 / 4 =
1) find the largest multiple of 2 so that
100 / (2^4 * 4) = 100 / 64 = 1
largest multiple is 4 (i=4)

Then we have 100 - 64 = 36 
36 / (4 * 2 * 2 * 2) = 36 / 32 = 1
Then
4 / 4 == 1
So the final result is 1 * 2 * 2 * 2 * 2 + 1 * 2 * 2 * 2 + 1 = 25
*/
namespace LeetCode_Solutions_CSharp.Solution
{
    public class S029_Divide_Two_Integers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0 | (dividend == Int32.MinValue && divisor == -1))
                return Int32.MaxValue;

            var sign = (dividend > 0) ^ (divisor > 0);
            uint divd = (uint)(dividend < 0 ? -dividend : dividend);
            uint divs = (uint)(divisor < 0 ? -divisor : divisor);
            var quot = 0;

            for (int i = 31; i>=0; i--)
            {
                if ((divd >> i) >= divs) //divd/(2^i) >=divisor
                {
                    quot += 1 << i; //2^i
                    divd -= divs << i; //divd - divs*(2^i)
                }
            }
            return sign ? -quot : quot;
        }
    }
}

