using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class RemoveDuplicatesfromSortedList_83
    {
        /*
        1.用一個叫做 current 的變數，指向鏈結串列的開頭 head。
        2.用一個迴圈，條件是 current 還有下一個節點。
        3.在迴圈裡面，檢查 current 的值和下一個節點的值是否相等。
            3.1如果相等，就把 current.next 指向 current.next.next，這樣就跳過並移除了重複的節點。
            3.2如果不相等，就讓 current 前進一步，指向 current.next。
        4.迴圈結束後，回傳原本的 head。
        */

        public ListNode DeleteDuplicates(ListNode head)
        {
            var current = head;
            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}