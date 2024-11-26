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
        public void GivenNumbersArray_WhenFindMaxSumForSubArrayLength_ThenReturnsExpectedMaxSum(int[] numbers, int subArrayLength, int expected)
        {
            // Arrange
            var findMaxSumSubArray = new FindMaxSumSubArray();

            // Act
            var result = findMaxSumSubArray.FindMaxSumForSubArrayLengthOptimized(numbers, subArrayLength);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("abcddca", 4)]
        [TestCase("abcbdaac", 4)]
        public void GivenAString_WhenFindLongestUniqueSubstringLength_ThenReturnsExpectedLength(string inputValue, int expected)
        {
            // Arrange
            var longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();

            // Act
            var result = longestSubstringWithoutRepeatingCharacters.FindLongestUniqueSubstringLengthOptimized(inputValue);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 1 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 2 }, 3)]
        [TestCase(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }, 5)]
        public void GivenFruitArray_WhenCollectMaximumFruits_ThenReturnsExpectedMaxFruits(int[] fruits, int expected)
        {
            // Arrange
            var maximumNumberOfFruitsCollectedInTwoBaskets = new MaximumNumberOfFruitsCollectedInTwoBaskets();

            // Act
            var result = maximumNumberOfFruitsCollectedInTwoBaskets.CollectMaximumFruits(fruits);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 2, 3, 1, 2, 4, 3 }, 7, 2)]
        public void GivenNumbersArray_WhenFindMinLengthForTargetSum_ThenReturnsExpectedLength(int[] numbers, int target, int expected)
        {
            // Arrange
            var minSubArrayLen = new MinSubArrayLen();

            // Act
            var result = minSubArrayLen.FindMinLengthForTargetSum(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
        public void GivenNumbersArray_WhenFindMaxAverageForSubArrayLength_ThenReturnsExpectedAverage(int[] numbers, int subArrayLength, double expected)
        {
            // Arrange
            var findMaxAverage = new FindMaxAverage();

            // Act
            var result = findMaxAverage.FindMaxAverageForSubArrayLength(numbers, subArrayLength);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}