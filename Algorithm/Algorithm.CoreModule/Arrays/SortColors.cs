using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays
{
    /*
    題目限制：
    必須使用 Two Pointers 演算法完成。
    必須使用原地排序，不能使用額外空間。
    時間複雜度應為 O(n)。
    */

    public class SortColors
    {
        /// <summary>
        /// 給定一個僅包含三種顏色（0、1、2）的整數數組 nums，
        /// 要求使用原地演算法將數組中的元素按顏色順序排序，順序為：0（紅色） -> 1（白色） -> 2（藍色）。
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] SortColorsInPlace(int[] numbers)
        {
            /*
            解題思路：
            此問題可以使用 雙指針法，採用一個變體的荷蘭國旗算法：

            使用三個指針：low（處理0）、high（處理2）、current（當前掃描的位置）。
            初始設定：low = 0，high = nums.Length - 1，current = 0。
            遍歷陣列：
            若 nums[current] == 0：將 nums[current] 與 nums[low] 交換，low++ 並移動 current++。
            若 nums[current] == 1：只需移動 current++。
            若 nums[current] == 2：將 nums[current] 與 nums[high] 交換，high--（但不移動 current，因為新的 nums[current] 需要重新檢查）。
            當 current 超過 high 時，排序完成。
            */

            int low = 0;
            int high = numbers.Length - 1;
            int current = 0;
            int temp = 0;
            while (current <= high)
            {
                if (numbers[current] == 0)
                {
                    temp = numbers[low];
                    numbers[low] = numbers[current];
                    numbers[current] = temp;

                    low += 1;
                    current += 1;
                    continue;
                }

                if (numbers[current] == 1)
                {
                    current += 1;
                    continue;
                }

                if (numbers[current] == 2)
                {
                    temp = numbers[high];
                    numbers[high] = numbers[current];
                    numbers[current] = temp;
                    high -= 1;
                }
            }

            return numbers;
        }
    }
}