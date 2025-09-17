using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class RemoveDuplicatesfromSortedListII_82
    {
        /*
        1.初始化：
        創建一個虛擬頭節點 dummy，指向原始的 head。
        創建一個遍歷指標 current，指向 dummy。

        2.主迴圈：
        while (current.next != null && current.next.next != null)：這個迴圈讓我們能夠檢查 current 的下一個節點和下下個節點，這正是判斷是否重複的關鍵。

        3.判斷重複：
        if (current.next.val == current.next.next.val)：如果它們的值相等，我們進入處理重複節點的流程。
            3.1處理重複節點：
            將重複的值存起來，例如 int duplicateValue = current.next.val;
            進入內部迴圈來跳過所有重複的節點：while (current.next != null && current.next.val == duplicateValue)
            在內部迴圈中，我們只需要做一件事：current.next = current.next.next;。這一步非常關鍵，它讓我們持續移除重複的節點。

        4.處理不重複節點：
        else 區塊，如果 current.next.val 與 current.next.next.val 不相等。
        我們只需要讓 current 向前移動一步：current = current.next;。

        回傳結果：
        當主迴圈結束時，我們只需要回傳虛擬頭節點的下一個節點，也就是 dummy.next。
        dummy 本身是我們為了方便操作而創建的，它不屬於原始鏈結串列的一部分。
        */

        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummy = new ListNode(0);
            dummy.next = head;
            var current = dummy;

            // current.next = head
            // current.next.next = head.next
            while (current.next != null && current.next.next != null)
            {
                if (current.next.val == current.next.next.val)
                {
                    var duplicateValue = current.next.val;
                    while (current.next != null && current.next.val == duplicateValue)
                    {
                        current.next = current.next.next;
                    }
                }
                else
                {
                    current = current.next;
                }
            }

            return dummy.next;
        }
    }
}