using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S021_Merge_Two_Sorted_Lists
    {

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            if (list1 == null) return list2; 
            if(list2 == null) return list1;

          
            list1 = new ListNode(int.MinValue, list1);
            var cur1 = list1;
            var cur2 = list2;

            while (cur1 != null && cur2 != null)
            {
                if (cur2.val >= cur1.val)
                {
                    if (cur1.next != null)
                    {
                        if (cur2.val < cur1.next.val)
                        {
                            //Insert right
                            cur1.next = new ListNode(cur2.val, cur1.next);
                            if (cur2.next == null) break;
                            cur2 = cur2.next;
                        }
                    }
                    else
                    {
                        //Insert right
                        cur1.next = new ListNode(cur2.val, cur1.next);
                        if (cur2.next == null) break;
                        cur2 = cur2.next;
                    }
                }
                cur1 = cur1.next;
            }
            return list1.next;
        }
    }
}
