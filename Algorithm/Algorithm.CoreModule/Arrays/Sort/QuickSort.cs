using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sort
{
    /*
    1.選擇基準點（Pivot）：
        從陣列中選一個元素作為基準點（通常選擇第一個元素、最後一個元素，或是中間的元素）。

    2.分區（Partition）：
    將陣列分成兩部分：
        左側包含所有比基準點小的元素。
        右側包含所有比基準點大的元素。
        基準點通常會放到正確的位置。

    3.遞迴排序：
        對左右兩個部分各自重複以上步驟，直到子陣列的大小為 1 或 0，這時陣列已經有序。

    4.合併結果：
        不需要顯式合併，因為排序會在原陣列中進行。
        快速排序法的平均時間複雜度為
        O(nlogn)，最壞情況是 O(n^2)（當基準點選擇不佳時，例如總是選到最大或最小值）。
    */

    public class QuickSort
    {
        public int[] Sort(int[] numbers)
        {
            QuickSortPartition(0, numbers.Length - 1, numbers);

            return numbers;
        }

        private void QuickSortPartition(int leftIndex, int rightIndex, int[] numbers)
        {
            if (leftIndex >= rightIndex)
            {
                // 如果只剩一個數字或沒有數字，不需要排序
                return;
            }

            // 基準點選擇最後一個元素
            int pivot = numbers[rightIndex];

            // actualPivotIndex 起始值是比基準點小的區域的最後一個索引
            // 分區開始前，比基準點小的元素還沒有，區域為空。
            // 因此，actualPivotIndex 要指向「比基準點小的區域的尾端」，此時「小於基準點的區域」還不存在，所以 actualPivotIndex 被設為 left - 1。
            int actualPivotIndex = leftIndex - 1;

            for (int i = leftIndex; i < rightIndex; i += 1)
            {
                // 若當前值小於基準點的值
                if (numbers[i] < pivot)
                {
                    // 計算最終基準點的索引
                    actualPivotIndex += 1;

                    // 交換小於基準點的值
                    swap(actualPivotIndex, i, numbers);
                }
            }

            // 計算最終基準點的索引
            actualPivotIndex += 1;

            // 把基準點放到正確位置
            swap(actualPivotIndex, rightIndex, numbers);

            // 遞迴排序左側與右側
            QuickSortPartition(leftIndex, actualPivotIndex - 1, numbers);
            QuickSortPartition(actualPivotIndex + 1, rightIndex, numbers);
        }

        private void swap(int actualPivotIndex, int minIndex, int[] numbers)
        {
            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[actualPivotIndex];
            numbers[actualPivotIndex] = temp;
        }
    }
}