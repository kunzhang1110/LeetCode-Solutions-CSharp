using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions_CSharp.Solution.Test
{

    [TestClass]
    public class T049_Group_Anagrams
    {
        [TestMethod]
        public void GroupAnagramsTest()
        {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var solution = new S049_Group_Anagrams();
            var result = solution.GroupAnagrams(input);

            AssertHelper.AssertList(
                new List<IList<string>>()
                {
                    new List<string> () { "eat", "tea", "ate" },
                    new List<string> () { "tan","nat" },
                    new List<string> () { "bat" }
                }, result);
        }

    }
}
