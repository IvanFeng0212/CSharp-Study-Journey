using Algorithm.CoreModule.Arrays.BinarySearch;
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
    public class Array_BinarySearch_Test
    {
        [TestCase(new int[] { -10, -3, 0, 5, 9, 12, 15 }, 9, 4)]
        [TestCase(new int[] { -10, -3, 0, 5, 9, 12, 15 }, 8, -1)]
        [TestCase(new int[] { -10, -3, 0, 5, 9, 12, 15 }, 0, 2)]
        [TestCase(new int[] { -10, -3, 0, 5, 9, 12, 15 }, -10, 0)]
        [TestCase(new int[] { -10, -3, 0, 5, 9, 12, 15 }, 15, 6)]
        public void GivenSortedNumbers_WhenFindTarget_ThenReturnExpectedIndex(int[] numbers, int target, int expected)
        {
            // Arrange
            var binarySearch = new BinarySearch();

            // Act
            var result = binarySearch.FindTarget(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 1, 5)]
        [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 7, 3)]
        [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 5, 1)]
        public void GivenRotatedSortedArray_WhenFindTargetIndex_ThenReturnExpectedIndex(int[] numbers, int target, int expected)
        {
            // Arrange
            var searchInRotatedSortedArray = new SearchInRotatedSortedArray();

            // Act
            var result = searchInRotatedSortedArray.FindTargetIndex(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void GivenSortedArray_WhenFindPosition_ThenReturnExpectedIndex(int[] numbers, int target, int expected)
        {
            // Arrange
            var searchInsertPosition = new SearchInsertPosition();

            // Act
            var result = searchInsertPosition.FindPosition(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 3, 5, 8, 12, 15 }, 7, 8)]
        [TestCase(new int[] { 1, 3, 5, 8, 12, 15 }, 4, 3)]
        [TestCase(new int[] { 1, 3, 5, 8, 12, 15 }, 15, 15)]
        public void GivenSortedArray_WhenFindClosestNumber_ThenReturnExpectedIndex(int[] numbers, int target, int expected)
        {
            // Arrange
            var closestElementToTarget = new ClosestElementToTarget();

            // Act
            var result = closestElementToTarget.FindClosestNumber(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}