using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.Stack
{
    public class ValidParentheses_20
    {
        /*
        1.準備工具
        一個空的字元堆疊 (Stack<char>)，用來存放左括號。
        一個字典 (Dictionary<char, char>)，用來儲存右括號對應的左括號。例如，你可以設定 ) 對應 (, } 對應 {, ] 對應 [.

        2.逐一檢查字串
        從頭到尾遍歷輸入字串中的每一個字元。

        3.處理左括號
        如果當前字元是左括號 (, {, [，將它 推入 (Push) 堆疊。這代表我們記錄下一個需要被關閉的括號。

        4.處理右括號
        如果當前字元是右括號 ), }, ]，你需要進行兩個關鍵檢查：
        檢查一：堆疊是否為空？ 如果堆疊已經是空的，表示我們沒有任何左括號可以與當前的右括號配對。這是一個無效的情況，可以直接回傳 false。
        檢查二：配對是否正確？ 如果堆疊不為空，取出堆疊最上方的字元，並將它與當前的右括號做比對。你可以利用之前建立的字典，判斷它們是否是正確的配對。如果比對不符，表示順序或類型不正確，也是一個無效的情況，回傳 false。如果配對成功，則繼續下一個字元的檢查。

        5.完成所有檢查
        當你遍歷完整個字串後，最後一步是檢查堆疊是否為空。
        如果堆疊是空的，表示所有左括號都已經找到了配對，並且被成功地從堆疊中取出。這時，字串是有效的，回傳 true。
        如果堆疊不是空的，表示還有未被關閉的左括號。這時，字串是無效的，回傳 false。
        */

        public bool IsValid(string s)
        {
            var charDictionary = new Dictionary<char, char>()
            {
                { ')','('},
                { '}','{'},
                { ']','['},
            };

            var charStack = new Stack<char>();

            foreach (var currentCharCode in s)
            {
                if (charDictionary.ContainsKey(currentCharCode))
                {
                    if (charStack.Count == 0)
                    {
                        return false;
                    }

                    var expectedCode = charDictionary[currentCharCode];
                    var topCharCode = charStack.Pop();
                    if (expectedCode != topCharCode)
                    {
                        return false;
                    }
                }
                else
                {
                    charStack.Push(currentCharCode);
                }
            }

            return charStack.Count == 0 ? true : false;
        }
    }
}