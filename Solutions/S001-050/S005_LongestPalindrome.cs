using System;
using System.Collections.Generic;
// Time O(N^2)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S005_LongestPalindrome
    {

        public string LongestPalindrome(string s)
        {

            var n = s.Length;
            var maxLength = 0;
            var maxStartIndex = 0;

            if (n <= 1) { return s; } // single character

            for (int i = 1; i < n-1; i++)
            {
                var low = i - 1;
                var high = i + 1;

                while (s[high] == s[i] && high < n - 1) high++;


                while (s[low] == s[i] && low > 0) low--;
   

                while (s[high] == s[low] && low > 0 && high < n - 1)
                {
  
                        high++;
                        low--;
                }
                
                if(high - low > maxLength)
                {
                    maxLength = high - low +1;
                    maxStartIndex = low;
                }
            }
            return s.Substring(maxStartIndex, maxLength);
        }
    }
}
