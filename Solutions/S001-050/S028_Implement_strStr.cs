using System;
using System.Collections.Generic;
// Time O(N^2)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S028_Implement_strStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") { return 0; }
            if (needle.Length > haystack.Length) { return -1; }
            int j = 0;
            int result = -1;
            for (int i = 0; i < haystack.Length - needle.Length+1; i++)
            {
                j = 0;
                while (haystack[i] == needle[j])
                {
                    if (j == needle.Length - 1) { result = i - needle.Length + 1; break; } //found match
                    i++;
                    j++;
                }
                if (result != -1) { break; }
                i = i - j;
            
            }
            return result;
        }
    }
}

