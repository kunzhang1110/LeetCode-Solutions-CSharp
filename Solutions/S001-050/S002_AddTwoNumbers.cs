using System;
using System.Collections.Generic;
//Time O(Max(N,M))

namespace LeetCode_Solutions_CSharp.Solution
{
    public class S002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {            
            ListNode result = new ListNode();
            ListNode current = result;
            int carry = 0;

            while(l1 != null || l2 != null)
            {
                var value1 = l1 != null ? l1.val : 0;
                var value2 = l2 != null ? l2.val : 0;
              
                var sum = value1 + value2 + carry;
                carry = sum / 10;
                sum %= 10;

                current.next = new ListNode(sum);

             
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
                current = current.next;

                if (carry > 0)  //multiple carry for adding two 2-digit numbers
                {
                    current.next = new ListNode(carry);
                }

            }

            return result.next;
        }
    }
}
