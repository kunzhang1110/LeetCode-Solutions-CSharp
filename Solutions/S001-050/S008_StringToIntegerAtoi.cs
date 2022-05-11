using System;
using System.Collections.Generic;
// Time O(N^2)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S008_StringToIntegerAtoi
    {

        public int MyAtoi(string s)
        {
            var result = 0;
            var startIndex = s.Length;

            for (int i = 0; i < s.Length; i++) // 48 is '0'
            {

                if (s[i] >= '0' && s[i] <= '9')
                {
                    var digit = s[i] - '0';
                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10))
                    {
                        result = int.MaxValue;
                        break;
                    }
                    result = result * 10 + digit;
                    
                    if (i < startIndex) 
                        startIndex = i;//get index of first digit
                }
            }

            if (startIndex > 0) //sign
            {
                if (s[startIndex - 1] == '-')
                {
                    if(result == int.MaxValue)
                    {
                        result = int.MinValue;
                    }
                    result *= -1;
                }
            }

            return result;
        }
    }
}
