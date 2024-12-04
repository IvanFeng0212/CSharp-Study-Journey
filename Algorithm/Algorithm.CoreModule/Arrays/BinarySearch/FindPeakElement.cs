using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.BinarySearch
{
    /*
    你可以假設 nums[-1] = nums[n] = -∞。
    你必須用 O(log n) 的時間複雜度解題。
    數組長度至少為 1，1 <= nums.length <= 1000。
    */

    public class FindPeakElement
    {
        /// <summary>
        /// 給定一個整數數組 nums，其中 nums[i] ≠ nums[i+1]，尋找峰值元素並返回其索引。
        /// 峰值元素是指嚴格大於其相鄰元素的元素。
        /// 如果數組中存在多個峰值，返回任意一個峰值的索引即可。
        /// </summary>
        /// <returns></returns>
        public int FindPeakIndex(int[] numbers)
        {
            /*
            1.題目本質：利用二分搜尋法來縮小範圍，因為峰值是由相鄰元素的比較決定的。
            2.二分法步驟：
                每次取中間元素 mid，與其右側相鄰元素 nums[mid + 1] 比較：
                    如果 nums[mid] < nums[mid + 1]，說明峰值一定在右側，因為 mid+1 後的元素可能有更大的值。
                    如果 nums[mid] > nums[mid + 1]，說明峰值一定在左側（包含 mid），因為 mid 自己可能是峰值。
                不斷縮小搜索範圍，直到只剩一個元素。
            3.返回結果：最後剩下的元素即為峰值，其索引即為結果。
            */
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex < rightIndex)
            {
                int mid = leftIndex + ((rightIndex - leftIndex) / 2);

                // 每次取中間元素 mid，與其右側相鄰元素 nums[mid + 1] 比較
                // 如果 nums[mid] < nums[mid + 1]，說明峰值一定在右側，因為 mid+1 後的元素可能有更大的值。
                if (numbers[mid] < numbers[mid + 1])
                {
                    leftIndex = mid + 1;
                }
                // 如果 nums[mid] > nums[mid + 1]，說明峰值一定在左側（包含 mid），因為 mid 自己可能是峰值。
                else
                {
                    rightIndex = mid;
                }
            }

            // 最後剩下的元素即為峰值，其索引即為結果。
            return leftIndex;
        }
    }
}