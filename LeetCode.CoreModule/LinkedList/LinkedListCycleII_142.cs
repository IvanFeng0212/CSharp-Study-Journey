using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class LinkedListCycleII_142
    {
        /*
        步驟一：初始化指針
        這一步我們已經討論過了，就是將 slow 和 fast 兩個指針都指向鏈結串列的頭部 head。

        步驟二：尋找相遇點
        使用一個迴圈（例如 while 迴圈），讓 slow 和 fast 指針開始移動。
        在每次迴圈中，slow 指針前進一步，而 fast 指針前進兩步。

        迴圈的條件是什麼呢？我們必須確保 fast 指針和 fast.next 都不為空，因為 fast 每次會移動兩步。
        在迴圈中，我們需要檢查 slow 和 fast 是否相遇了。如果相遇了，就跳出這個迴圈。

        步驟三：尋找循環起點
        如果我們從上一個迴圈跳出來，並且 slow 和 fast 是相等的，這代表我們已經找到相遇點了。
        這時候，我們需要一個新的指針，可以稱它為 ptr1，讓它回到鏈結串列的頭部 head。
        同時，我們讓另一個指針，可以繼續用 slow，從相遇點開始。
        現在，讓 ptr1 和 slow 兩個指針同時、一步一步地往前走。
        當這兩個指針再次相遇時，它們所在的節點就是循環的起點。
        將這個節點回傳。

        步驟四：處理沒有循環的情況
        如果你在步驟二的迴圈中，因為 fast 或 fast.next 為空而跳出了迴圈，這表示鏈結串列沒有循環。
        在這種情況下，我們應該回傳 null。
        */

        public ListNode DetectCycle(ListNode head)
        {
            var fast = head;
            var slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow) break;
            }

            if (fast != null && fast.next != null)
            {
                fast = head;
                while (fast != slow)
                {
                    fast = fast.next;
                    slow = slow.next;
                }

                return fast;
            }
            else
            {
                return null;
            }
        }
    }
}