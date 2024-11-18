using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.TwoPointers
{
    /*
    題目限制
    輸入數組按升序排序。
    該數組至少有兩個整數。
    可以假設不會發生溢出。
    */

    public class FindPairWithClosestSum
    {
        /// <summary>
        /// 找到陣列中和最接近目標值的兩個數字
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] FindClosestSumPair(int[] numbers, int target)
        {
            /*
            解題思路：
            初始化 Two Pointers：將一個指標（left）放在陣列開頭，另一個指標（right）放在陣列結尾。
            迭代：當 left 小於 right 時：
            計算 left 和 right 指向元素的和。
            如果這個和恰好等於目標值，直接返回該配對，因為這是最接近目標的可能。
            如果不完全相同，但比之前紀錄的和更接近目標，更新最接近的和和配對。
            如果當前的和小於目標，將 left 向右移以增加和。
            如果當前的和大於目標，將 right 向左移以減少和。
            返回最接近的配對：迴圈結束後，返回紀錄的最接近配對。
            */
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            if (numbers.Length == 2 && numbers[leftIndex] + numbers[rightIndex] != target) return new int[0];

            int lessThanTargetLeftIndex = 0;
            int lessThanTargetRightIndex = 0;
            int lessThanTarget = int.MinValue;

            int greatThanTargetLeftIndex = 0;
            int greatThanTargetRightIndex = 0;
            int greatThanTarget = int.MaxValue;

            int sum = 0;
            while (leftIndex < rightIndex)
            {
                sum = numbers[leftIndex] + numbers[rightIndex];

                if (sum == target)
                {
                    return new int[] { numbers[leftIndex], numbers[rightIndex] };
                }
                // 如果不完全相同，但比之前紀錄的和更接近目標，更新最接近的和和配對
                else if (sum < target)
                {
                    if (sum > lessThanTarget)
                    {
                        lessThanTarget = sum;
                        lessThanTargetLeftIndex = leftIndex;
                        lessThanTargetRightIndex = rightIndex;
                    }

                    // 如果當前的和小於目標，將 left 向右移以增加和
                    leftIndex += 1;
                }
                else
                {
                    if (sum < greatThanTarget)
                    {
                        greatThanTarget = sum;
                        greatThanTargetLeftIndex = leftIndex;
                        greatThanTargetRightIndex = rightIndex;
                    }

                    // 如果當前的和大於目標，將 right 向左移以減少和
                    rightIndex -= 1;
                }
            }

            var diffLess = target - lessThanTarget;
            var diffGreat = greatThanTarget - target;
            if (diffLess < diffGreat)
            {
                return new int[] { numbers[lessThanTargetLeftIndex], numbers[lessThanTargetRightIndex] };
            }

            return new int[] { numbers[greatThanTargetLeftIndex], numbers[greatThanTargetRightIndex] };
        }
    }
}