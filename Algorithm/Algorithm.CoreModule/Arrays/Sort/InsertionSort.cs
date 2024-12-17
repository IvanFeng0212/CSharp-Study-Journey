using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sort
{
    /*
    1.將第一個元素視為已經排序好。
    2.從第二個元素開始，逐一檢查，找到正確的位置插入。
    3.在插入時，將比當前元素大的值向右移動，為插入騰出空間。
    4.重複這個過程，直到所有元素排序完成。
    */

    public class InsertionSort
    {
        /// <summary>
        /// 對給定的整數數組進行插入排序。
        /// </summary>
        /// <param name="numbers">要排序的整數數組</param>
        /// <returns>排序後的整數數組</returns>
        public int[] Sort(int[] numbers)
        {
            // 將第一個元素視為已經排序好
            int startIndex = 1;

            // 從第二個元素開始，逐一檢查
            for (int i = startIndex; i < numbers.Length; i += 1)
            {
                int current = numbers[i];

                // 當前位置的前一個位置開始判斷，並逐漸往陣列左邊確認
                int previousIndex = i - 1;

                while (previousIndex >= 0 && numbers[previousIndex] > current)
                {
                    // 將比當前元素大的值向右移動，為插入騰出空間
                    numbers[previousIndex + 1] = numbers[previousIndex];
                    previousIndex -= 1;
                }

                // 找到正確的位置插入
                numbers[previousIndex + 1] = current;
            }

            return numbers;
        }
    }
}