using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.SlidingWindow
{
    /*
    題目限制：
    1 <= nums.length <= 10^5
    1 <= k <= nums.length
    -10^4 <= nums[i] <= 10^4
    */

    public class FindMaxSumSubArray
    {
        /// <summary>
        /// 題目：找到大小為 K 的子陣列的最大和
        /// 給定一個整數數組 nums 和一個整數 k，請找出數組中所有大小為 k 的子陣列中，和的最大值，並返回該值。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="subArrayLength"></param>
        /// <returns></returns>
        public int FindMaxSumForSubArrayLength(int[] numbers, int subArrayLength)
        {
            /*
            解題思路：
            使用 Sliding Window 技巧：
            先計算第一個窗口的和，這是窗口初始狀態。
            然後，通過滑動窗口（移除窗口的第一個數字並添加新的數字）計算後續窗口的和。
            在每次更新窗口和的過程中，記錄出現的最大和。
            相較於暴力法檢查所有子陣列，滑動窗口的時間複雜度為O(n)，更為高效。
            */
            int left = 0;
            int right = subArrayLength - 1;
            int maxSum = 0;
            int subArraySum = 0;
            while (right < numbers.Length)
            {
                subArraySum = 0;
                for (int i = left; i <= right; i += 1)
                {
                    subArraySum += numbers[i];
                }

                if (subArraySum > maxSum)
                {
                    maxSum = subArraySum;
                }

                left += 1;
                right += 1;
            }

            return maxSum;
        }

        public int FindMaxSumForSubArrayLengthOptimized(int[] numbers, int subArrayLength)
        {
            /*
            解題思路：
            使用 Sliding Window 技巧：
            先計算第一個窗口的和，這是窗口初始狀態。
            然後，通過滑動窗口（移除窗口的第一個數字並添加新的數字）計算後續窗口的和。
            在每次更新窗口和的過程中，記錄出現的最大和。
            相較於暴力法檢查所有子陣列，滑動窗口的時間複雜度為O(n)，更為高效。
            */
            int subArraySum = 0;
            int maxSum = 0;
            for (int i = 0; i < subArrayLength; i += 1)
            {
                subArraySum += numbers[i];
            }

            for (int i = subArrayLength; i < numbers.Length; i += 1)
            {
                subArraySum += numbers[i] - numbers[i - subArrayLength];
                maxSum = Math.Max(maxSum, subArraySum);
            }

            return maxSum;
        }
    }
}