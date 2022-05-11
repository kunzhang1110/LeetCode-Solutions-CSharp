using System;
using System.Collections.Generic;
/* 
 * Time O(log(N))
 * Space O(log(N))
 */
//Binary tree multiplication

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S050_Pow

    {
        public double MyPow(double x, int n)
        {
            if (x == 0) return 0;
            if (n == 0) return 1;
            return square(x, n);

        }

        public double square(double x, int n)
        {
            if (n == 1) return x;
            if (n == -1) return 1 / x;
            var result = square(x, n / 2);
            if (n % 2 == 0) 
            {
                return result * result;
            }
            else
            {
                if (n > 0)
                {
                    return result * result * x;
                }
                else
                {
                    return result * result * 1/x;
                }
                
            }
        }
    }
}

