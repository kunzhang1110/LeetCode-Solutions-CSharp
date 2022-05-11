using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S020_Valid_Parentheses
    {

        public bool IsValid(string s)
        {
            Stack<char> sStack = new Stack<char>();
            Dictionary<char, char> sDictionary = new Dictionary<char, char>()
            {
                { '(', ')' }, {'{', '}'}, {'[', ']'}
            };
            if(s.Length <= 1) { return false; }

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    sStack.Push(s[i]);

                }
                else
                {
                    if(sStack.Count == 0) { return false; }
                    var c = sStack.Pop();
                    if (sDictionary[c] == s[i]) continue;
                    return false;
                }
            }
            if (sStack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
