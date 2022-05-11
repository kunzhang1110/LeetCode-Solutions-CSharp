using System;
using System.Collections.Generic;
// Time O(N)
/* Backtracking
if (o != c)
{
    add );
    add(;
}
else
{
    add(;
}
*/

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S022_Generate_Parentheses
    {
        private static List<String> result;
        private static int num = 0;

        public IList<string> GenerateParenthesis(int n)
        {
            result = new List<string>();
            num = n;
            parGenerator(0, 1, "(");
            return result;
        }

        private void parGenerator(int closed, int open, string s)
        {
            if (closed > num || open > num)
                return;

            if (closed == num && open == num)
            {
                result.Add(s);
                return;
            }
            if (closed == open) //if same only '(' is valid to start
                parGenerator(closed, open + 1, s + "(");
            else //if '(' not equal to ')' we can add both
            {
                parGenerator(closed, open + 1, s + "(");
                parGenerator(closed + 1, open, s + ")");
            }
        }
    }
}

