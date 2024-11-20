using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.CoreModule.Arrays.SlidingWindow;

namespace Algorithm.Test
{
    /*
    Given：描述了測試的前置條件。
    When：描述了測試的行為。
    Then：描述了預期的結果。
    */

    [TestFixture]
    public class Array_SlidingWindow_Test
    {
        [TestCase(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9)]
        public void GivenNumbersArray_WhenFindMaxSumForSpecifiedSubArrayLength_ThenReturnsExpectedMaxSum(int[] numbers, int subArrayLength, int expected)
        {
            var findMaxSumSubArray = new FindMaxSumSubArray();

            var result = findMaxSumSubArray.FindMaxSumForSubArrayLengthOptimized(numbers, subArrayLength);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("abcddca", 4)]
        [TestCase("abcbdaac", 4)]
        public void GivenAString_WhenFindLongestUniqueSubstringLength_ThenReturnLongestUniqueSubstringLength(string inputValue, int expected)
        {
            var longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();

            var result = longestSubstringWithoutRepeatingCharacters.FindLongestUniqueSubstringLengthOptimized(inputValue);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}