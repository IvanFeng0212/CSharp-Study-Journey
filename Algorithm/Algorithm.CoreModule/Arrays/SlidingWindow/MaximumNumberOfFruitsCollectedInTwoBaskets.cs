using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.SlidingWindow
{
    /*
    題目限制：
    1 <= fruits.length <= 10^5
    0 <= fruits[i] < fruits.length
    */

    public class MaximumNumberOfFruitsCollectedInTwoBaskets
    {
        /// <summary>
        /// 假設你有一排果樹，每棵果樹上只長一種水果，用一個整數陣列 fruits 代表果樹上的水果種類，其中 fruits[i] 表示第 i 棵樹上的水果類型（編號）。
        /// 你有兩個籃子，每個籃子最多只能裝一種水果。請找到你最多能收集到的水果數量，且必須連續收集（即，從陣列中選擇一段連續子陣列）。
        /// </summary>
        /// <param name="fruits"></param>
        /// <returns></returns>
        public int CollectMaximumFruits(int[] fruits)
        {
            /*
            解題思路：
            使用滑動窗口來維持一個最多包含兩種水果的窗口
            滑動窗口的核心：

            我們需要維持一個窗口，其中水果種類數目最多為 2。
            如果窗口內的水果種類數目超過 2，縮小窗口（移動左邊界），直到恢復有效狀態。
            資料結構：

            使用一個 Dictionary<int, int> 來記錄當前窗口內每種水果的數量。
            更新窗口：

            每次將右指針向右移動時，更新 Dictionary 中的數據。
            檢查當前窗口是否有效（種類數目不超過 2）。
            如果無效，移動左指針並更新 Dictionary。
            結果：

            在每一步中計算當前窗口的大小，並記錄最大的窗口大小。
            */

            int leftIndex = 0;
            Dictionary<int, int> fruitCount = new Dictionary<int, int>();
            int maxFruits = 0;
            int currentFruits = 0;
            for (int rightIndex = 0; rightIndex < fruits.Length; rightIndex += 1)
            {
                // 如果當前水果不在字典中且字典中已經有兩種水果
                if (!fruitCount.ContainsKey(fruits[rightIndex]) && fruitCount.Keys.Count == 2)
                {
                    // 縮小窗口，直到字典中只剩下一種水果
                    while (fruitCount.Keys.Count > 1)
                    {
                        fruitCount[fruits[leftIndex]] -= 1;
                        currentFruits -= 1;
                        if (fruitCount[fruits[leftIndex]] == 0)
                        {
                            fruitCount.Remove(fruits[leftIndex]);
                        }

                        leftIndex += 1;
                    }
                }

                // 將當前水果添加到字典中
                if (!fruitCount.ContainsKey(fruits[rightIndex]))
                {
                    fruitCount[fruits[rightIndex]] = 0;
                }

                // 更新最大水果數量
                fruitCount[fruits[rightIndex]] += 1;
                currentFruits += 1;

                // 記錄最大的窗口大小
                maxFruits = Math.Max(maxFruits, currentFruits);
            }

            return maxFruits;
        }
    }
}