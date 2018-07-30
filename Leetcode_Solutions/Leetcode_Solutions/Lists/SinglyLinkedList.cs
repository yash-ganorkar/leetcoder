using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Lists
{
    class SinglyLinkedList
    {
        public ListNode CreateLinkedList()
        {
            ListNode head = new ListNode(10);

            head.Next = new ListNode(10);
            head.Next.Next = new ListNode(51);
            head.Next.Next.Next = new ListNode(15);
            head.Next.Next.Next.Next = new ListNode(10);
            head.Next.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next.Next = new ListNode(1);
            return head;
        }

        public void DisplayList(ListNode list)
        {
            Console.WriteLine("------------- Linked List------------");

            ListNode ls = list;
            while (ls.Next != null)
            {
                Console.Write(ls.Val + " -> ");
                ls = ls.Next;
            }

            Console.Write(ls.Val);
        }

        public int GetCountIterative(ListNode list)
        {
            int count = 0;
            ListNode current = list;
            if (current == null) return count;
            else
            {
                while(current != null)
                {
                    current = current.Next;
                    count++;
                }
            }
            return count;
        }

        public int NthNodeFromEnd(ListNode list, int n)
        {
            ListNode slowPtr = list;
            ListNode fastPtr = list;

            for(int i = 0; i < n; i++)
            {
                fastPtr = fastPtr.Next;
            }

            while(fastPtr != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next;
            }

            return slowPtr.Val;
        }

        public int FindMiddleOfList(ListNode list)
        {
            ListNode slowPtr = list;
            ListNode fastPtr = list;

            while (fastPtr != null && fastPtr.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;
            }
            return slowPtr.Val;
        }

        public ListNode DeleteNode(ListNode head, int n)
        {
            if (head == null) return null;
            head.Next = DeleteNode(head.Next, n);
            return head.Val == n ? head.Next : head;
        }

        public int GetCountRecursive(ListNode list)
        {
            return list == null ? 0 : GetCountRecursiveHelper(list);
        }

        private int GetCountRecursiveHelper(ListNode list)
        {
            if (list == null) return 0;

            return 1 + GetCountRecursiveHelper(list.Next);
        }
    }
}
