using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Lists
{
    class ListNode
    {
        public int Val { get; set; }

        public ListNode Next;

        public ListNode(int number)
        {
            this.Val = number;
            this.Next = null;
        }

        public ListNode() { }
    }
}
