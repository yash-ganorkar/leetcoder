using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Lists
{
    class AddTwoNumbersII
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> l1Stack = new Stack<int>();
            Stack<int> l2Stack = new Stack<int>();

            ListNode curr = l1;
            while(curr != null)
            {
                l1Stack.Push(curr.Val);
                curr = curr.Next;
            }

            curr = l2;
            while (curr != null)
            {
                l2Stack.Push(curr.Val);
                curr = curr.Next;
            }

            int sum = 0;
            ListNode list = new ListNode(0);

            while(l1Stack.Count > 0 || l2Stack.Count > 0)
            {
                if (l1Stack.Count > 0) sum += l1Stack.Pop();
                if (l2Stack.Count > 0) sum += l2Stack.Pop();
                list.Val = sum % 10;
                ListNode head = new ListNode(sum / 10);
                head.Next = list;
                list = head;
                sum /= 10;
            }

            return list.Val == 0 ? list.Next : list;
        }
    }
}
