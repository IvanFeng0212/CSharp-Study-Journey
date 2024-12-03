using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.BinarySearch
{
    /*
    1 <= nums.Length <= 10^4
    -10^4 <= nums[i] <= 10^4
    nums 按升序排列且沒有重複值。
    -10^4 <= target <= 10^4
    */

    public class ClosestElementToTarget
    {
        /// <summary>
        /// 給定一個升序排列的整數陣列 nums 和一個目標值 target，
        /// 請在陣列中找到最接近 target 的數字。
        /// 如果有兩個數字同樣接近，返回較小的那一個。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindClosestNumber(int[] numbers, int target)
        {
            /*
            1.使用 Binary Search 快速定位目標值 target 在陣列中的位置。如果直接找到，直接返回目標值。
            2.如果未找到，則 Binary Search 的結束位置會提供與目標值接近的兩個候選數字：
                左邊界值（小於 target 的最大值）
                右邊界值（大於 target 的最小值）
            3.比較目標值與這兩個候選數字之間的距離，選出最接近的數字。如果距離相等，返回較小的數字。
            */
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex <= rightIndex && rightIndex - leftIndex > 1)
            {
                int mid = (leftIndex + (rightIndex - leftIndex) / 2);
                if (numbers[mid] == target) return target;

                if (numbers[mid] > target)
                {
                    rightIndex = mid;
                }
                else
                {
                    leftIndex = mid;
                }
            }

            var rightDiff = Math.Abs(numbers[rightIndex] - target);
            var leftDiff = Math.Abs(numbers[leftIndex] - target);

            return leftDiff > rightDiff ? numbers[rightIndex] : numbers[leftIndex];
        }

        public int FindClosestNumberOptimized(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;

            // Binary Search 主體
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] == target)
                    return numbers[mid];

                if (numbers[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // 確定邊界候選值
            int leftCandidate = (right >= 0) ? numbers[right] : int.MinValue;
            int rightCandidate = (left < numbers.Length) ? numbers[left] : int.MaxValue;

            // 比較距離
            if (Math.Abs(leftCandidate - target) <= Math.Abs(rightCandidate - target))
                return leftCandidate;
            else
                return rightCandidate;
        }
    }
}