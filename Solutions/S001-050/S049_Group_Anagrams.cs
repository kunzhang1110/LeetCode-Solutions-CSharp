using System;
using System.Collections.Generic;
/* 
 * Time O(N)
 * Space O(N)
 */

//Use sorted string as key to a dictionary
namespace LeetCode_Solutions_CSharp.Solution
{
    public class S049_Group_Anagrams

    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var key = GetAnagramKey(str);
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(str);
                    //Console.WriteLine(key);
                }
                else { dic.Add(key, new List<string>() { str }); }
            }

            var result = new List<IList<string>>();
            foreach(var keyValuePair in dic)
            {
                result.Add(keyValuePair.Value);              
            }
            return result;
        }

        public string GetAnagramKey(string str)
        {
            var strArray = str.ToCharArray();
            Array.Sort(strArray);
            return String.Join("", strArray);
        }
    }
}

