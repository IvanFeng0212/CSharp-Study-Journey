using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.SlidingWindow
{
    /*
    1 <= nums.length <= 10^5
    1 <= nums[i] <= 10^4
    1 <= target <= 10^9
    */

    public class MinSubArrayLen
    {
        /// <summary>
        /// 最短子陣列的總和大於等於目標值
        /// 給定一個整數數組 nums 和一個正整數 target，找到一個最短的連續子陣列，
        /// 要求其總和大於等於 target，並返回該子陣列的長度。如果沒有符合條件的子陣列，則返回 0。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindMinLengthForTargetSum(int[] numbers, int target)
        {
            /*
            使用滑動窗口（起點 start 和終點 end）。
            初始化總和 sum = 0 和最小長度 minLength = int.MaxValue。
            循環 end 從頭到尾遍歷數組：
            把 nums[end] 加到 sum 中。
            當 sum >= target 時，嘗試縮小窗口，更新最小長度：
            計算當前窗口長度 end - start + 1。
            更新 minLength 為較小值。
            把 nums[start] 從 sum 中移除並增加 start，以縮小窗口。
            返回 minLength，如果未找到符合條件的子陣列，返回 0。
            */

            int minLength = int.MaxValue;
            int sum = 0;
            int startIndex = 0;
            // end 從頭到尾遍歷數組
            for (int endIndex = 0; endIndex < numbers.Length; endIndex += 1)
            {
                // 把 nums[end] 加到 sum 中
                sum += numbers[endIndex];

                while (sum >= target)
                {
                    // 計算當前窗口長度 end - start + 1
                    // 更新 minLength 為較小值
                    minLength = Math.Min((endIndex - startIndex) + 1, minLength);

                    // nums[start] 從 sum 中移除並增加 start，以縮小窗口
                    sum -= numbers[startIndex];
                    startIndex += 1;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}