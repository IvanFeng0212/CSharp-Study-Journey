using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.BinarySearch
{
    /*
    1≤nums.length≤10^4
    -10^4≤nums[i],target≤10^4
    nums 中的元素按嚴格遞增排序。
    */

    public class SearchInsertPosition
    {
        /// <summary>
        /// 查找插入位置
        /// 給定一個排序的整數數組 nums 和一個目標值 target，
        /// 請在數組中找到目標值並返回其索引。
        /// 如果目標值不存在於數組中，
        /// 返回它將會被插入的位置索引。
        /// </summary>
        /// <returns></returns>
        public int FindPosition(int[] numbers, int target)
        {
            /*
            1.使用二分搜尋法。
            2.設定左右指針 left 和 right。
            3.遍歷數組，計算中間索引 mid。
            4.如果 nums[mid] 等於 target，直接返回索引。
            5.如果 nums[mid] < target，將 left 移到 mid + 1。
            6.如果 nums[mid] > target，將 right 移到 mid - 1。
            7.如果搜尋結束仍未找到目標值，返回 left，此時 left 為插入位置。
            */

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex <= rightIndex)
            {
                // 遍歷數組，計算中間索引 mid
                int mid = leftIndex + ((rightIndex - leftIndex) / 2);

                // 如果 nums[mid] 等於 target，直接返回索引
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

            return leftIndex;
        }
    }
}