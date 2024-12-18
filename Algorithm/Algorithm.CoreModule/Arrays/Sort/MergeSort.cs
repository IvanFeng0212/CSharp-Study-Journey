using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sort
{
    /*
    MergeSort 解題步驟
    1. 問題拆解：分割 (Divide)
        目標： 將陣列分成兩部分，直到每個子陣列只有一個元素為止。
        步驟：
            計算中間索引：mid = (left + right) / 2。
            將陣列分為兩個子陣列：
            左子陣列範圍：left 到 mid。
            右子陣列範圍：mid + 1 到 right。
            對每個子陣列遞迴進行分割，直到只剩下一個元素。
    2. 子問題求解：合併 (Merge)
        目標： 合併兩個已排序的子陣列成為一個排序完成的陣列。
        步驟：
            使用兩個指針分別指向左子陣列與右子陣列的起始位置。
            比較指針指向的元素，將較小的元素放入臨時陣列，並移動該指針。
            當某一子陣列的指針到達尾端時，將另一子陣列的剩餘元素依次放入臨時陣列。
            將臨時陣列中的元素複製回主陣列對應位置。
    3. 基本條件：停止分割
        條件： 當子陣列只剩一個元素時，視為已排序，無需進一步處理。
    4. 主程式：整體流程
        目標： 呼叫分割與合併函數，完成排序。
        步驟：
        呼叫 MergeSort，將陣列分割至最小單位。
        從最小的子陣列開始，逐步合併成更大的已排序陣列。
        最後合併為完整的已排序陣列。
         */

    public class MergeSort
    {
        /// <summary>
        /// 對給定的整數數組進行合併排序。
        /// </summary>
        /// <param name="numbers">要排序的整數數組</param>
        /// <returns>排序後的整數數組</returns>
        public int[] Sort(int[] numbers)
        {
            Sort(numbers, 0, numbers.Length - 1);

            return numbers;
        }

        /// <summary>
        /// 遞迴地將數組分割並排序。
        /// </summary>
        /// <param name="numbers">要排序的整數數組</param>
        /// <param name="leftIndex">左邊界索引</param>
        /// <param name="rightIndex">右邊界索引</param>
        /// <returns></returns>
        private void Sort(int[] numbers, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            // 計算中間點，避免 (left + right) 的數字溢位
            int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

            // 遞迴對左半部分進行排序
            Sort(numbers, leftIndex, midIndex);

            // 遞迴對右半部分進行排序
            Sort(numbers, midIndex + 1, rightIndex);

            // 合併已排序的左右兩部分
            Merge(numbers, leftIndex, midIndex, rightIndex);
        }

        /// <summary>
        /// 將兩個已排序的子數組合併成一個排序的數組。
        /// </summary>
        /// <param name="numbers">原始整數數組</param>
        /// <param name="leftIndex">左子數組的起始索引</param>
        /// <param name="midIndex">中間索引</param>
        /// <param name="rightIndex">右子數組的終止索引</param>
        private void Merge(int[] numbers, int leftIndex, int midIndex, int rightIndex)
        {
            // 確定左右子數組的長度
            int childLeftArrayLength = midIndex - leftIndex + 1; // 左半部分元素個數
            int childRightArrayLength = rightIndex - midIndex; // 右半部分元素個數

            // 創建臨時陣列來存儲子數組
            int[] childLeftArray = new int[childLeftArrayLength];
            int[] childRightArray = new int[childRightArrayLength];

            // 將數據複製到臨時陣列
            for (int i = 0; i < childLeftArrayLength; i += 1)
            {
                // leftIndex + i，計算出主陣列中對應左子陣列的元素索引
                childLeftArray[i] = numbers[leftIndex + i];
            }

            for (int i = 0; i < childRightArrayLength; i += 1)
            {
                // midIndex + 1 + i，計算出主陣列中對應右子陣列的元素索引
                childRightArray[i] = numbers[midIndex + 1 + i];
            }

            // 初始化指針
            int leftPointer = 0;
            int rightPointer = 0;
            int sortedIndex = leftIndex;

            // 合併臨時數組到原始數組
            while (leftPointer < childLeftArrayLength && rightPointer < childRightArrayLength)
            {
                if (childLeftArray[leftPointer] <= childRightArray[rightPointer])
                {
                    numbers[sortedIndex] = childLeftArray[leftPointer];

                    leftPointer += 1; // 移動左子陣列指針
                }
                else
                {
                    numbers[sortedIndex] = childRightArray[rightPointer];

                    rightPointer += 1; // 移動右子陣列指針
                }

                sortedIndex += 1;
            }

            // 將剩餘的左子數組元素放入原始數組
            while (leftPointer < childLeftArrayLength)
            {
                numbers[sortedIndex] = childLeftArray[leftPointer];
                leftPointer += 1;
                sortedIndex += 1;
            }

            // 將剩餘的右子數組元素放入原始數組
            while (rightPointer < childRightArrayLength)
            {
                numbers[sortedIndex] = childRightArray[rightPointer];
                rightPointer += 1;
                sortedIndex += 1;
            }
        }
    }
}