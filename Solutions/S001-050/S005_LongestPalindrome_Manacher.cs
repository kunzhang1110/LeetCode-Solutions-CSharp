using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S005_LongestPalindrome_Manacher
    {
   
        public string LongestPalindrome(string s)
        {
            //pad string with # e.g. #a#b#a#
            var padded_string = new char[s.Length * 2 + 1];
            for (int i = 0; i < s.Length; i++)
            {
                padded_string[i * 2] = '#';
                padded_string[i * 2 + 1] = s[i];
            }
            padded_string[padded_string.Length-1] = '#';

            var p = new int[padded_string.Length];  //store length of LPS at i
            int right = 0, center = 0;
            var longestCenter = 0;


            for (int i = 0; i < padded_string.Length; i++)
            {
                if (right > i)
                    p[i] = Math.Min(p[center * 2 - i], right - i); //p[i]>=P[i']

                while (i - 1 - p[i] >= 0 && i + 1 + p[i] < padded_string.Length && padded_string[i - 1 - p[i]] == padded_string[i + 1 + p[i]])
                    p[i]++;

                if (i + p[i] > right) //greater than previous
                {
                    center = i;
                    right = i + p[i];
                }

                if (p[i] > p[longestCenter])
                    longestCenter = i;
            }

            var range = p[longestCenter];
            return s.Substring((longestCenter - range) / 2, range);
        }
       


    }
}
