using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.BinarySearch
{
    /*
    陣列已經排序（遞增順序）。
    時間複雜度應為 O(logn)。
    不允許使用內建的搜尋函數，如 Array.BinarySearch。
    */

    public class BinarySearch
    {
        /// <summary>
        /// 給定一個排序好的整數陣列 nums 和一個目標值 target，
        /// 判斷目標值是否存在於陣列中
        /// 如果存在，返回其索引；否則，返回 -1
        /// </summary>
        /// <returns></returns>
        public int FindTarget(int[] numbers, int target)
        {
            /*
            使用二分搜尋法，透過不斷縮小搜尋範圍來查找目標值：
            設置兩個指標 left 和 right 分別指向陣列的最左端和最右端。
            計算中間索引 mid，比較 nums[mid] 和 target：
            如果 nums[mid] == target，則返回 mid。
            如果 nums[mid] < target，則將 left 移動到 mid + 1，縮小左側。
            如果 nums[mid] > target，則將 right 移動到 mid - 1，縮小右側。
            如果搜尋結束時未找到，返回 -1。
            通過這種方式，我們能有效地在 O(logn) 時間內找到目標值。
            */

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int mid = (leftIndex + rightIndex) / 2;

                // nums[mid] == target，則返回 mid
                if (numbers[mid] == target) return mid;

                // nums[mid] < target，則將 left 移動到 mid + 1
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