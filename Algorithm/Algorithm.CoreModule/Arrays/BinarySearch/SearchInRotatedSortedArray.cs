using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.BinarySearch
{
    /*
    陣列中的元素 不重複。
    時間複雜度要求為 O(log n)。
    1 <= nums.length <= 5000
    -10^4 <= nums[i], target <= 10^4
    */

    public class SearchInRotatedSortedArray
    {
        /// <summary>
        /// 給定一個已按照升序排列的整數陣列 nums，
        /// 該陣列在某個未知的旋轉點進行過旋轉（例如，[4,5,6,7,0,1,2]），
        /// 以及一個目標值 target，請找出目標值的索引。
        /// 如果目標值不存在於陣列中，返回 -1。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindTargetIndex(int[] numbers, int target)
        {
            /*
            透過 Binary Search 找到陣列中的旋轉點（即最小值的索引）。
            確定目標值在旋轉陣列的哪一段（左半段或右半段）。
            在相應的區間再次進行 Binary Search。
            */
            var minIndex = 0;
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            // 透過 Binary Search 找到陣列中的旋轉點（即最小值的索引）
            while (leftIndex < rightIndex)
            {
                int mid = leftIndex + ((rightIndex - leftIndex) / 2);

                if (numbers[mid] > numbers[rightIndex])
                {
                    leftIndex = mid + 1;
                }
                else
                {
                    rightIndex = mid;
                }
            }

            minIndex = leftIndex;

            // 確定目標值在旋轉陣列的哪一段（左半段或右半段）
            leftIndex = 0;
            rightIndex = numbers.Length - 1;
            if (target >= numbers[minIndex] && target <= numbers[rightIndex])
            {
                leftIndex = minIndex;
            }
            else
            {
                rightIndex = minIndex - 1;
            }

            // 在相應的區間再次進行 Binary Search
            while (leftIndex <= rightIndex)
            {
                int mid = leftIndex + ((rightIndex - leftIndex) / 2);

                if (numbers[mid] == target) return mid;

                if (numbers[mid] < target)
                {
                    leftIndex = mid + 1;
                }
                else
                {
                    rightIndex = mid - 1;
                }
            }

            return -1;
        }
    }
}