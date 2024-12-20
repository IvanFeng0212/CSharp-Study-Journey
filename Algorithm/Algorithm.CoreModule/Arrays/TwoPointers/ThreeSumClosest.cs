﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.TwoPointers
{
    /*
    題目限制：
    陣列 nums 的長度 n 至少為 3。
    每個數字的範圍為 -1000 到 1000。
    target 的範圍為 -10^4 到 10^4。
    */

    public class ThreeSumClosest
    {
        /// <summary>
        /// 找出陣列中三個整數之和最接近 target。返回這三個數字之和
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindClosestSumOfThreeNumbers(int[] numbers, int target)
        {
            /*
            解題思路
            排序：首先將 nums 陣列排序，方便後續使用 Two Pointers 技巧。
            遍歷數組並設置指針：
            使用 i 遍歷每個數字，並將當前數字作為三數之一。
            對於每個 i，設定 left 指針為 i+1，right 指針為陣列的最後一位。
            使用 Two Pointers：
            計算 currentSum = nums[i] + nums[left] + nums[right]。
            若 currentSum 接近 target，更新最近的和 closestSum。
            若 currentSum 小於 target，移動 left 指針；若 currentSum 大於 target，移動 right 指針。
            返回結果：最後返回最接近的 closestSum。
            */

            if (numbers.Length == 3) return numbers.Sum(x => x);

            // 排序陣列
            Array.Sort(numbers);

            int leftIndex = 0;
            int rightIndex = 0;
            int closestSum = 0;
            int distinct = int.MaxValue;
            int currentSum = 0;
            for (int i = 0; i + 1 < numbers.Length; i++)
            {
                leftIndex = i + 1;
                rightIndex = numbers.Length - 1;
                while (leftIndex < rightIndex)
                {
                    currentSum = numbers[i] + numbers[leftIndex] + numbers[rightIndex];

                    // 若找到更接近的和，則更新 closestSum
                    if (Math.Abs(target - currentSum) < distinct)
                    {
                        distinct = Math.Abs(target - currentSum);
                        closestSum = currentSum;
                    }

                    if (currentSum < target) // 若和小於 target，移動 left 指針
                    {
                        leftIndex += 1;
                    }
                    else if (currentSum > target) // 若和大於 target，移動 right 指針
                    {
                        rightIndex -= 1;
                    }
                    else
                    {
                        // 當 currentSum 等於 target 時，直接返回結果
                        return currentSum;
                    }
                }
            }

            return closestSum;
        }
    }
}