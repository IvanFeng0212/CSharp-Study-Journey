using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sorting
{
    /*
    字串陣列的長度 n 最大為 10^3。
    每個字串的長度最大為 100。
    必須使用排序演算法。
    */

    public class StringSorter
    {
        /// <summary>
        /// 給定一個由小寫字母組成的字串陣列，請根據每個字串的字母順序排序。
        /// 返回新的字串陣列，其中每個字串的字母已按字母順序排列，並且整個陣列也根據字母順序排序。
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] SortStringsByLettersAndArray(string[] inputStrings)
        {
            /*
            解題思路：
            1.字母排序：對陣列中的每個字串，將其轉換為字元陣列，排序後再轉回字串。這可以使用 C# 的 OrderBy 方法實現。
            2.陣列排序：對所有排序後的字串進行整體排序，使用標準的排序演算法如 Array.Sort 或 OrderBy。
            3.雙重排序：第一層排序是對每個字串內的字母排序，第二層是對整個字串陣列排序。
            */
            for (int i = 0; i < inputStrings.Length; i += 1)
            {
                // 字母排序：對陣列中的每個字串，將其轉換為字元陣列，排序後再轉回字串。這可以使用 C# 的 OrderBy 方法實現
                var charArray = inputStrings[i].ToCharArray().OrderBy(x => x);

                inputStrings[i] = string.Join("", charArray);
            }

            Array.Sort(inputStrings);

            return inputStrings;
        }
    }
}