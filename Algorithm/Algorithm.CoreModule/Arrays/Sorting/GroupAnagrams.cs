using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.Sorting
{
    /*
    字串長度範圍為 1 <= words[i].Length <= 100
    字串的總數量為 1 <= words.Length <= 10^4
    所有字串僅包含小寫字母。
    */

    public class GroupAnagrams
    {
        /// <summary>
        /// 重新排列字母組合
        /// 給定一個字串陣列 string[] words，
        /// 請依照字母順序對每個字串中的字母進行排序，
        /// 並依照排序後的字母組合將字串分組。
        /// 最終，輸出分組後的字串陣列列表（無需排序）。
        /// </summary>
        /// <param name="words">字串陣列</param>
        /// <returns>分組後的字串陣列列表</returns>
        public List<List<string>> GroupByAnagrams(string[] words)
        {
            /*
            1.轉換關鍵：
            每個字串都可以透過排序其字母，轉換為相同的"標準形式"。例如，"eat" 和 "tea" 經過排序後都變成 "aet"。
            這個排序後的字串可以用作"分組的鍵"。

            2.資料結構：
            使用 Dictionary<string, List<string>> 來存放分組結果，其中鍵是排序後的字串，值是該分組內的原字串列表。

            3.步驟：
            遍歷陣列中的每個字串，對字母排序後生成鍵。
            檢查鍵是否已存在於字典：
            若存在，將原字串加入對應的值中。
            若不存在，創建新的鍵值對。
            最後將字典中的值轉為列表輸出。

            4.排序效率：
            單個字串排序的複雜度是 O(L log L)（其中 L 是字串長度）。
            總體時間複雜度約為 O(N * L log L)，其中 N 是字串總數。
                */

            Dictionary<string, List<string>> groupDic = new Dictionary<string, List<string>>();
            for (int i = 0; i < words.Length; i += 1)
            {
                var charArray = words[i].ToCharArray();

                Array.Sort(charArray);

                var sortedWord = string.Join("", charArray);
                if (!groupDic.ContainsKey(sortedWord))
                {
                    groupDic[sortedWord] = new List<string>();
                }

                groupDic[sortedWord].Add(words[i]);
            }

            return groupDic.Values.ToList();
        }
    }
}