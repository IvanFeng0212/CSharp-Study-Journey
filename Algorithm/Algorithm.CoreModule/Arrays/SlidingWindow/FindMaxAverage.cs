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

    public class FindMaxAverage
    {
        /// <summary>
        /// 給定一個整數陣列 nums 和一個整數 k，請找到一個長度為 k 的子陣列，其平均值是所有長度為 k 子陣列中最大的，並返回該最大平均值。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="subArrayLength"></param>
        /// <returns></returns>
        public double FindMaxAverageForSubArrayLength(int[] numbers, int subArrayLength)
        {
            /*
            由於我們需要找到固定長度 k 的子陣列中最大平均值，
            因此可以先將問題轉化為找到最大總和 k 的子陣列，
            最後再除以 k 即可。

            1.初始化窗口：
            計算陣列中第一個長度為 k 的子陣列總和，作為初始窗口總和。

            2.滑動窗口：
            從第 k 個元素開始，將窗口向右滑動一格，每次減去窗口左端的值，並加上窗口右端的值。
            同時更新最大總和。

            計算結果：
            將最大總和除以 k 即為答案。
            */

            int sumSubArray = 0;
            int maxSum = 0;
            // 1.計算陣列中第一個長度為 k 的子陣列總和，作為初始窗口總和
            for (int i = 0; i < subArrayLength; i += 1)
            {
                sumSubArray += numbers[i];
            }

            // 2.從第 k 個元素開始，將窗口向右滑動一格，每次減去窗口左端的值，並加上窗口右端的值。
            // 同時更新最大總和
            for (int i = subArrayLength; i < numbers.Length; i += 1)
            {
                sumSubArray += (numbers[i] - numbers[i - subArrayLength]);
                maxSum = Math.Max(maxSum, sumSubArray);
            }

            // 3.將最大總和除以 k 即為答案
            return (double)maxSum / subArrayLength;
        }
    }
}