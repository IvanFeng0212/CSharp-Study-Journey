using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}