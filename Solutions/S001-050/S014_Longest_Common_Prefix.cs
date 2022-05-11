using System;
using System.Collections.Generic;
// Time O(N*M)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S014_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            var initialString = strs[0];
            var minStringLength = initialString.Length;             
            for (int i = 0; i < minStringLength; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != initialString[i])
                    {
                        break;
                    }
                    if (strs[j][i] == initialString[i] && j == strs.Length - 1)
                    {
                        result += initialString[i];
                    }
                    if (strs[j].Length < minStringLength)
                    {
                        minStringLength = strs[j].Length;
                    }
                }
            }
            return result;
        }

    }
}
