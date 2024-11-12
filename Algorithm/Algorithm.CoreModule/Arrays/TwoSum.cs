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
        public int[] FindTwoSumIndices(int[] numbers, int target)
        {
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