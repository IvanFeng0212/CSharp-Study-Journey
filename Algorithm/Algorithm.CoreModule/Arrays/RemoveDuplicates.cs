using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays
{
    /*
    nums 是已排序的整數陣列。
    只修改陣列並在常數空間內完成。
    輸入陣列可能是空的。
     */

    public class RemoveDuplicates
    {
        public int FindMaxUniqueLength(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int slowIndex = 0;
            for (int fastIndex = 1; fastIndex < numbers.Length; fastIndex += 1)
            {
                // 數值重複，fastIndex 繼續往前，slowIndex 不動
                if (numbers[slowIndex] == numbers[fastIndex])
                    continue;

                // 當發現不重複的元素時，
                // slowIndex + 1，
                // 替換元素為新找到的
                slowIndex += 1;
                numbers[slowIndex] = numbers[fastIndex];
            }

            // 返回 Index + 1 即為最大長度
            return slowIndex + 1;
        }
    }
}