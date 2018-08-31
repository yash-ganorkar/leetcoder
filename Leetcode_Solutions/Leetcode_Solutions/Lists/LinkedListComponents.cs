using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Lists
{
    class LinkedListComponents
    {
        public int NumComponents(ListNode head, int[] G)
        {
            int ans = 2147483647;

            HashSet<int> GSet = new HashSet<int>();

            foreach (int i in G) GSet.Add(i);

            ListNode curr = head;

            while (curr != null)
            {
                if (GSet.Contains(curr.Val) && (!GSet.Contains(curr.Next.Val) || curr.Next == null)) ans++;
                curr = curr.Next;
            }

            return ans;
        }
    }
}
