using System;
using System.Collections.Generic;
// Time O(4^N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S017_Letter_Phone_Number
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if (digits == "") return result;

            var letterPhoneDic = new Dictionary<char, List<char>>() {
                {'2', new List<Char>() {'a', 'b', 'c'}},
                {'3', new List<Char>() {'d', 'e', 'f'}},
                {'4', new List<Char>() {'g', 'h', 'i'}},
                {'5', new List<Char>() {'j', 'k', 'l'}},
                {'6', new List<Char>() {'m', 'n', 'o'}},
                {'7', new List<Char>() {'p', 'q', 'r', 's'}},
                {'8', new List<Char>() {'t', 'u', 'v'}},
                {'9', new List<Char>() {'w', 'x', 'y', 'z'}},
            };

            for(int i = 0; i < letterPhoneDic[digits[0]].Count; i++)
            {
                getString(0, i, "");
            }

            void getString(int digitIdx, int idx, string s)
            {

                var newLetterList = new List<char>();
                var newLetter = "";
                if(letterPhoneDic.TryGetValue(digits[digitIdx], out newLetterList))
                {
                    newLetter = newLetterList[idx].ToString();
                };
                

                if (digitIdx == digits.Length-1)
                {
                    Console.WriteLine(s + newLetter);
                    result.Add(s + newLetter);
                    return;
                }
                for(int i = 0; i < letterPhoneDic[digits[digitIdx+1]].Count; i++)
                {  
                    getString(digitIdx + 1, i, s+ newLetter);
                }
            }


            return result;

        }


    }
}
