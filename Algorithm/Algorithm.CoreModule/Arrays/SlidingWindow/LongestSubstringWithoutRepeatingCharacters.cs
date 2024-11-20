using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoreModule.Arrays.SlidingWindow
{
    /*
    題目限制
    字符串 s 的長度範圍為 0 <= s.length <= 10^5。
    字符串只包含 ASCII 字符。
    */

    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// 給定一個字符串 s，找出其中 不含重複字符的最長子字符串的長度。
        /// <returns></returns>
        public int FindLongestUniqueSubstringLength(string inputValue)
        {
            /*
            解題思路
            使用 Sliding Window 方法，用兩個指針標記子字符串的起點和終點：
            左指針表示子字符串的開始位置。
            右指針遍歷字符串以擴展窗口。
            使用一個集合來追蹤窗口內的字符是否重複。
            當右指針的字符不在集合中時，將其加入窗口並更新結果。
            當右指針的字符已在集合中時，通過移動左指針縮小窗口，直到窗口內不包含該字符。
            最後，返回窗口最大長度。
            */

            int rightIndex = 0;
            int maxLength = 0;
            int removeCount = 0;
            List<char> tempUniqueChar = new List<char>();
            while (rightIndex < inputValue.Length)
            {
                if (tempUniqueChar.Contains(inputValue[rightIndex]))
                {
                    // 更新不含重複字符的最長長度
                    maxLength = Math.Max(maxLength, tempUniqueChar.Count);

                    var repeatCharIndex = tempUniqueChar.IndexOf(inputValue[rightIndex]);
                    removeCount = 0;
                    while (removeCount < repeatCharIndex + 1)
                    {
                        tempUniqueChar.RemoveAt(0);
                        removeCount += 1;
                    }
                }

                tempUniqueChar.Add(inputValue[rightIndex]);
                rightIndex += 1;
            }

            return maxLength;
        }

        public int FindLongestUniqueSubstringLengthOptimized(string inputValue)
        {
            /*
            解題思路
            使用 Sliding Window 方法，用兩個指針標記子字符串的起點和終點：
            左指針表示子字符串的開始位置。
            右指針遍歷字符串以擴展窗口。
            使用一個集合來追蹤窗口內的字符是否重複。
            當右指針的字符不在集合中時，將其加入窗口並更新結果。
            當右指針的字符已在集合中時，通過移動左指針縮小窗口，直到窗口內不包含該字符。
            最後，返回窗口最大長度。
            */

            int leftIndex = 0;
            int maxLength = 0;
            List<char> tempUniqueChar = new List<char>();
            for (int rightIndex = 0; rightIndex < inputValue.Length - 1; rightIndex += 1)
            {
                // 當右指針的字符已在集合中時
                while (tempUniqueChar.Contains(inputValue[rightIndex]))
                {
                    // 移動左指針縮小窗口
                    tempUniqueChar.Remove(inputValue[leftIndex]);
                    leftIndex += 1;
                }

                tempUniqueChar.Add(inputValue[rightIndex]);
                maxLength = Math.Max(maxLength, tempUniqueChar.Count);
            }

            return maxLength;
        }
    }
}