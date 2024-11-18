using Algorithm.CoreModule.Arrays.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Test
{
    /*
    Given：描述了測試的前置條件。
    When：描述了測試的行為。
    Then：描述了預期的結果。
    */

    [TestFixture]
    public class Array_TwoPointers_Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 9, new int[] { 2, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8, new int[] { 1, 7 })]
        public void GivenSortedNumbers_WhenFindTwoSumIndices_ThenReturnCorrectIndexPositions(int[] numbers, int target, int[] expected)
        {
            var twoSum = new TwoSum();

            var results = twoSum.FindTwoSumIndices(numbers, target);

            Assert.That(results, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 0, 0, 1, 2, 2, 4, 4 }, 4)]
        [TestCase(new int[] { 0, 0, 1, 2, 2, 3, 4, 4 }, 5)]
        public void GivenSortedNumbers_WhenFindMaxUniqueLength_ThenReturnMaxUniqueLength(int[] numbers, int expected)
        {
            var removeDuplicates = new RemoveDuplicates();

            var results = removeDuplicates.FindMaxUniqueLength(numbers);

            Assert.That(results, Is.EqualTo(expected));
        }

        [TestCase(new int[] { -1, 2, 3, 5, 8, 10 }, 7, new int[] { -1, 8 })]
        [TestCase(new int[] { -1, 2, 3, 5, 8, 10 }, 4, new int[] { -1, 5 })]
        [TestCase(new int[] { -1, 2, 3, 5, 8, 10 }, 6, new int[] { -1, 8 })]
        public void GivenSortedNumbers_WhenFindClosestSumPair_ThenReturnClosestSumPairIndex(int[] numbers, int target, int[] expected)
        {
            var findPairWithClosestSum = new FindPairWithClosestSum();

            var results = findPairWithClosestSum.FindClosestSumPair(numbers, target);

            Assert.That(results, Is.EqualTo(expected));
        }

        [TestCase(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [TestCase(new int[] { -1, 2, -4 }, 1, -3)]
        public void GivenNumbers_WhenFindClosestSumOfThreeNumbers_ThenReturnClosestSumResult(int[] numbers, int target, int expected)
        {
            var threeSumClosest = new ThreeSumClosest();

            var results = threeSumClosest.FindClosestSumOfThreeNumbers(numbers, target);

            Assert.That(results, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [TestCase(new int[] { 1, 0, 2, 1, 2, 0, 0 }, new int[] { 0, 0, 0, 1, 1, 2, 2 })]
        public void GivenNumbers_WhenSortColorsInPlace_ThenReturnSortedColors(int[] numbers, int[] expected)
        {
            var sortColors = new SortColors();

            var results = sortColors.SortColorsInPlace(numbers);

            Assert.That(results, Is.EqualTo(expected));
        }
    }
}