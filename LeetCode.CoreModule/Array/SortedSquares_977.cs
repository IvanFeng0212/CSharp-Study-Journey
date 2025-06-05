using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.Array
{
    public class SortedSquares_977
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] results = new int[nums.Length];
            int resultLastIndex = results.Length - 1;
            int left = 0;
            int right = nums.Length - 1;
            int tempLeft = int.MinValue;
            int tempRight = int.MinValue;
            while (left <= right)
            {
                tempLeft = nums[left] * nums[left];
                tempRight = nums[right] * nums[right];
                if (tempLeft >= tempRight)
                {
                    results[resultLastIndex] = tempLeft;
                    left += 1;
                }
                else
                {
                    results[resultLastIndex] = tempRight;
                    right -= 1;
                }

                resultLastIndex -= 1;
            }

            return results;
        }
    }
}