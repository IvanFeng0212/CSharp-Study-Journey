using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.Stack
{
    public class ReverseLinkedList_206
    {
        /*
        第一階段：推入 Stack
        目的：利用 Stack 的「後進先出 (LIFO)」特性，將鏈結串列的順序反轉。
        步驟：
            1.用一個迴圈遍歷原始鏈結串列。
            2.將每一個節點都 Push 進 Stack 中。
        第二階段：彈出並重新連接
        目的：將 Stack 中反轉後的節點，重新組合成一個新的鏈結串列。
        步驟：
            1.彈出 Stack 中第一個節點，將它設為新鏈結串列的頭部 (newHead)，並用另一個指標 (newTail) 也指向它。
            2.進入迴圈，只要 Stack 中還有節點，就持續 Pop 出來。
            3.在迴圈中，將 newTail 的 next 參考指向新彈出的節點。
            4.將 newTail 往前移動到新彈出的節點，準備下一次連接。
            5.迴圈結束後，將 newTail 的 next 參考設為 null，以終止鏈結串列。
        最終結果
        回傳 newHead，它就是反轉後鏈結串列的頭部。
        */

        public ListNode ReverseList(ListNode head)
        {
            var stackListNode = new Stack<ListNode>();
            while (head != null)
            {
                stackListNode.Push(head);
                head = head.next;
            }

            if (stackListNode.Count == 0)
            {
                return head;
            }

            var newHead = stackListNode.Pop();
            ListNode newTail = newHead;
            while (stackListNode.TryPop(out ListNode newNode))
            {
                newTail.next = newNode;
                newTail = newNode;
            }

            newTail.next = null;
            return newHead;
        }
    }
}