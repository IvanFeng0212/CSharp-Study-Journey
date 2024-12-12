using Algorithm.CoreModule.Arrays.Sorting;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
    public class Array_Sorting_Test
    {
        private static IEnumerable<TestCaseData> GroupAnagramsTestCaseData
        {
            get
            {
                yield return new TestCaseData
                 (
                    new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                    new List<List<string>>()
                    {
                        new List<string> { "bat" },
                        new List<string> { "eat", "tea", "ate" },
                        new List<string> { "tan", "nat" }
                    }
                );//.SetName("Group anagrams"); // 測試報告中會顯示這個名稱，清楚知道哪個測試成功或失敗

                yield return new TestCaseData
                 (
                    new string[] { "tea" },
                    new List<List<string>>()
                    {
                        new List<string> { "tea" }
                    }
                );
            }
        }

        [Test, TestCaseSource(nameof(GroupAnagramsTestCaseData))]
        public void GivenAnStringArray_WhenGroupByAnagrams_ThenReturnExpectedIndex(string[] words, List<List<string>> expected)
        {
            // Arrange
            var groupAnagrams = new GroupAnagrams();

            // Act
            var result = groupAnagrams.GroupByAnagrams(words);

            // Assert
            // 比較集合時不考慮內容的順序，但內部的子集合順序不可以不同
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [TestCase(new string[] { "apple", "banana", "cherry", "date" }, new string[] { "aaabnn", "adet", "aelpp", "cehrry" })]
        public void GivenAStringArray_WhenSortStringsByLettersAndArray_ThenReturnExpectedIndex(string[] words, string[] expected)
        {
            // Arrange
            var stringSorter = new StringSorter();

            // Act
            var result = stringSorter.SortStringsByLettersAndArray(words);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 3, 1, 2, 4, 5, 6 }, new int[] { 6, 4, 2, 1, 5, 3 })]
        public void GivenAnArray_WhenSortEvenOdd_ThenReturnExpectedIndex(int[] numbers, int[] expected)
        {
            // Arrange
            var sortArrayByParity = new SortArrayByParity();

            // Act
            var result = sortArrayByParity.SortEvenOdd(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}