using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sorting
{
    /*
    輸入：
    nums 是一個長度為 n 的整數陣列，其中 1≤n≤10^5。
    每個數字的範圍為 −10^5到10^5。

    輸出：
    返回排序後的陣列，偶數在前，奇數在後，順序可以不保留。
    時間與空間限制：
    時間：O(n)
    空間：O(1)
    */

    public class SortArrayByParity
    {
        /// <summary>
        /// 給定一個整數陣列 nums，
        /// 請將陣列中的所有偶數放到陣列的前半部分，
        /// 奇數放到後半部分，並返回排列後的陣列。
        /// 要求：你需要在 O(n) 時間複雜度內完成，
        /// 並且只能使用額外的常數空間。
        /// </summary>
        /// <param name="numbers">整數陣列</param>
        /// <returns>排序後的陣列，偶數在前，奇數在後</returns>
        public int[] SortEvenOdd(int[] numbers)
        {
            /*
            解題思路
            1雙指針法 (Two Pointers)
            使用一個指針指向陣列的開頭，另一個指針指向陣列的結尾：
            如果左指針指向的是偶數，則移動左指針。
            如果右指針指向的是奇數，則移動右指針。
            如果左指針指向的是奇數，右指針指向的是偶數，交換它們，然後分別移動指針。

            2.這種方法能在 O(n) 時間內完成排序，且僅用到了常數額外空間。
            */

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            int tmp = 0;
            while (leftIndex < rightIndex)
            {
                // 如果左指針指向的是偶數，則移動左指針
                if (numbers[leftIndex] % 2 == 0)
                {
                    leftIndex += 1;
                }
                // 如果右指針指向的是奇數，則移動右指針
                else if (numbers[rightIndex] % 2 != 0)
                {
                    rightIndex -= 1;
                }
                // 如果左指針指向的是奇數，右指針指向的是偶數，交換它們，然後分別移動指針
                else
                {
                    tmp = numbers[leftIndex];
                    numbers[leftIndex] = numbers[rightIndex];
                    numbers[rightIndex] = tmp;

                    leftIndex += 1;
                    rightIndex -= 1;
                }
            }

            return numbers;
        }
    }
}