using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.TwoPointers
{
    /*
    題目限制
    nums 是已排序的整數陣列。
    只修改陣列並在常數空間內完成。
    輸入陣列可能是空的。
    */

    public class RemoveDuplicates
    {
        /// <summary>
        /// 移除排序陣列中的重複項，返回最大不重複的數量
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int FindMaxUniqueLength(int[] numbers)
        {
            /*
            解題思路
            因為陣列是排序的，我們可以利用 Two Pointers 的方式來解決這個問題，具體步驟如下：

            使用兩個指針：slow 和 fast。
            初始化時，slow 指針在位置 0，fast 指針從位置 1 開始。
            當 fast 指針所指的元素和 slow 指針所指的元素不一樣時，說明找到了一個新的不重複的元素。此時將 slow 指針向前移動一位，並將 fast 所指的元素複製到 slow 的位置。
            若兩個指針指的值相同，fast 指針繼續向右移動。
            當 fast 遍歷完陣列後，slow + 1 即為不重複的元素數量。
            */

            if (numbers == null || numbers.Length == 0) return 0;

            int slowIndex = 0;
            for (int fastIndex = 1; fastIndex < numbers.Length; fastIndex += 1)
            {
                // 數值重複，fastIndex 繼續往前，slowIndex 不動
                if (numbers[slowIndex] == numbers[fastIndex])
                    continue;

                // 當發現不重複的元素時，
                // slowIndex + 1，
                // 替換元素為新找到的
                slowIndex += 1;
                numbers[slowIndex] = numbers[fastIndex];
            }

            // 返回 Index + 1 即為最大長度
            return slowIndex + 1;
        }
    }
}