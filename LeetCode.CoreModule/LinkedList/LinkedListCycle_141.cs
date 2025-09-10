using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class LinkedListCycle_141
    {
        /*
        快慢指標演算法總結
        邊界條件處理：

        初始化指標：
        建立 slow 和 fast 兩個 ListNode 型態的指標。
        將 slow 指向 head。
        將 fast 指向 head。

        迴圈遍歷：
        使用 while 迴圈，條件是 fast != null 且 fast.next != null。
        (邊界條件處理如果 fast 為 null，或 fast.next 為 null，則回傳 false。)
        在迴圈中先讓 slow 和 fast 分別移動：
        slow = slow.next
        fast = fast.next.next
        接著判斷 slow 和 fast 是否相等。如果相等，表示有循環，回傳 true。

        迴圈結束：
        如果迴圈結束，表示快指標已經到達末端，沒有相遇，則回傳 false。

        */

        public bool HasCycle(ListNode head)
        {
            // head = [3,2,0,-4,2]
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) return true;
            }

            return false;
        }
    }
}