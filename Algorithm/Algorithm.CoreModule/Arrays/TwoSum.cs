using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays
{
    /*
    題目限制
    陣列 numbers 具有非遞減排序（升序）。
    陣列中的每個元素都是唯一的。
    只會有一組解。
    陣列長度在 [2, 3 * 10^4] 範圍內。
    整數 target 的範圍是 [-10^9, 10^9]。
    */

    public class TwoSum
    {
        /// <summary>
        /// 從陣列中找到兩個數字，使它們的和等於目標值，並回傳它們的索引（以 1 為基底）
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] FindTwoSumIndices(int[] numbers, int target)
        {
            /*
            解題思路
            由於陣列已排序，因此可以利用「雙指針」的特性高效地搜尋答案：

            初始化兩個指針，left 指針指向陣列的開頭，right 指針指向陣列的末尾。
            計算 numbers[left] + numbers[right] 的和：
            如果和等於 target，則找到解並返回。
            如果和小於 target，表示 numbers[left] 太小，將 left 向右移動一格。
            如果和大於 target，表示 numbers[right] 太大，將 right 向左移動一格。
            重複步驟 2，直到找到符合條件的兩個數字。
            此方法的時間複雜度為 O(n)，只需遍歷一次陣列。
            */

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex < rightIndex)
            {
                var twoSum = numbers[leftIndex] + numbers[rightIndex];

                if (twoSum == target)
                {
                    // 回傳索引，以 1 為基底
                    return new int[] { leftIndex + 1, rightIndex + 1 };
                }

                if (twoSum < target)
                {
                    leftIndex += 1; // 左指針右移
                }
                else
                {
                    rightIndex -= 1; // 右指針左移
                }
            }

            return new int[0]; // 如果沒有找到符合的條件，返回空陣列
        }
    }
}