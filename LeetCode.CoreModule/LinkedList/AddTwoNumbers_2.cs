using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.LinkedList
{
    public class AddTwoNumbers_2
    {
        /*
        1.建立 一個 dummyHead 節點和一個 curr 節點，curr 指向 dummyHead。

        2.設定 兩個指標 p1 和 p2，分別指向 l1 和 l2 的頭部。

        3.初始化 進位 carry 為 0。

        4.進入迴圈，迴圈條件是 p1 != null 或 p2 != null 或 carry > 0。

        5.在迴圈內：
            取得 p1 和 p2 的值，如果為 null 則取 0。
            計算 sum = p1.val + p2.val + carry。
            更新 carry = sum / 10。
            在 curr 的後面建立一個新節點，其值為 sum % 10。
            移動 curr、p1 和 p2 到下一個節點。

        6.回傳 dummyHead.next。
        */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(0);
            var current = dummy;
            var carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                var sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            return dummy.next;
        }
    }
}