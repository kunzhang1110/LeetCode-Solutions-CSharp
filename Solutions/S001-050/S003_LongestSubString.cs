using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S003_LongestSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max_length = 0;
            Dictionary<char,int> dic = new Dictionary<char,int>(); //store positions of char

            for(int i = 0; i < s.Length; i++)
            {
          
                if (dic.ContainsKey(s[i]))
                {
                    if (max_length < i - dic[s[i]])
                    {
                        max_length = i - dic[s[i]];
                    };
                    dic[s[i]] = i;
                }
                else
                {
                    dic.Add(s[i], i);
                }
            }

        return max_length;
        }
    }
}
