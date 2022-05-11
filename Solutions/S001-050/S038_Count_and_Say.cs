using System;
using System.Collections.Generic;
/* Time O(N)
CountAndSay(int n)
    = "1", if n=1
    = ConvertToSay(CountAndSay(n-1)), if n>1
 */

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S038_Count_and_Say
    {

        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            return ConvertToSay(CountAndSay(n - 1));           
        }

        private string ConvertToSay(string digitalString) //Convert digital to saying; `332251->23321511`
        {
            var say = "";
            var countList = new List<int[]>();

            var count = 1;
            var number = digitalString[0] - '0';
            for (int i = 1; i < digitalString.Length; i++)
            {
                if (digitalString[i] != digitalString[i - 1])
                {
                        say += count.ToString() + number;
                    count = 1;
                    number = digitalString[i] - '0';
                }
                else count++;
            }
                say += count.ToString() + number; //add last one
            return say;
        }

    }
}

