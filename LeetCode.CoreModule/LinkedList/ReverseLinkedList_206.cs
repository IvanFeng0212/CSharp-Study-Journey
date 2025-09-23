using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class ReverseLinkedList_206
    {
        /*
        1.初始化：我們需要三個變數，一個 previous (null)、一個 current (指向原始頭部) 和一個 next_node 來暫存。
        2.迴圈：當 current 不為 null 時，重複以下三個步驟：
            暫存下一個節點。
            反轉目前節點的連結，使其指向 previous。
            移動 previous 和 current 到新的位置。
        3.回傳：迴圈結束時，回傳 previous，它就是反轉後的頭部。
        */

        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;
            ListNode nextNode = null;
            while (current != null)
            {
                nextNode = current.next;
                current.next = previous;
                previous = current;
                current = nextNode;
            }

            return previous;
        }
    }
}