using System;
using System.Collections.Generic;
//Time O(n)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S013_Roman_to_Integer
    {

        public int RomanToInt(string s)
        {
            var RomanDic = new Dictionary<string, int>()
            { {"I",1},{"V", 5}, {"X", 10}, {"L", 50}, 
                {"C", 100}, {"D", 500}, {"M", 1000}, {"IV", 4 },
                {"IX", 9 }, {"XL", 40 },{"XC", 90 }, {"CD", 400 },{"CM", 900 } };

            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var singleCharString = "" + s[i];
                if (i + 1 < s.Length)
                {
                    var doubleCharString = "" + s[i] + s[i + 1];
                    if (RomanDic.ContainsKey(doubleCharString))
                    {
                        result += RomanDic[doubleCharString];
                        i++;
                        continue;
                    }
                }
                result += RomanDic[singleCharString];
            }

            return result;

        }

    }
}
