using System;
using System.Collections.Generic;
// Time O(N)

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S019_Remove_Nth_Node_From_End
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null) { return head; }
            var start = new ListNode();
            start.next = head;
            var cur = start;
            
            var size = 0;
            //Traverse till end
            while(cur.next != null)
            {
                cur = cur.next;
                size++;
            }
            var deletePos = size - n;
            if (deletePos >= 0)
            {
                cur = start;
                for(var i = 0; i < deletePos; i++) // one node before deleting node
                {
                    cur = cur.next;
                }
                var del = cur.next; //deleting node
                var con = del.next; //connecting node
                cur.next = con;
                del.next = null;
                return start.next;
            }
            else
            {
                return head;
            }
        }
    }
}
