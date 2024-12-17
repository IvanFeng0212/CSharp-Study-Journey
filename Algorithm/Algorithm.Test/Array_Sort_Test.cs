using Algorithm.CoreModule.Arrays.Sort;
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

    public class Array_Sort_Test
    {
        [TestCase(new int[] { 8, 3, 10, 7, 4, 9, 2 }, new int[] { 2, 3, 4, 7, 8, 9, 10 })]
        [TestCase(new int[] { 8, 3, 7, 4, 9, 5 }, new int[] { 3, 4, 5, 7, 8, 9 })]
        public void GivenAnArray_WhenQuickSort_ThenReturnExpectedArray(int[] numbers, int[] expected)
        {
            // Arrange
            var quickSort = new QuickSort();

            // Act
            var result = quickSort.Sort(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 8, 3, 7, 4, 9, 2 }, new int[] { 2, 3, 4, 7, 8, 9 })]
        [TestCase(new int[] { 8, 3, 7, 4, 9, 5 }, new int[] { 3, 4, 5, 7, 8, 9 })]
        public void GivenAnArray_WhenInsertionSort_ThenReturnExpectedArray(int[] numbers, int[] expected)
        {
            // Arrange
            var insertionSort = new InsertionSort();

            // Act
            var result = insertionSort.Sort(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}