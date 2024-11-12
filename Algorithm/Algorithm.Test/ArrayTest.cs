using Algorithm.CoreModule.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Test
{
    [TestFixture]
    public class ArrayTest
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 9, new int[] { 2, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8, new int[] { 1, 7 })]
        public void GivenSortedNumbers_WhenFindTwoSumIndices_ThenReturnCorrectIndexPositions(int[] numbers, int target, int[] expects)
        {
            var twoSum = new TwoSum();

            var results = twoSum.FindTwoSumIndices(numbers, target);

            Assert.That(results, Is.EqualTo(expects));
        }

        [TestCase(new int[] { 0, 0, 1, 2, 2, 4, 4 }, 4)]
        [TestCase(new int[] { 0, 0, 1, 2, 2, 3, 4, 4 }, 5)]
        public void GivenSortedNumbers_WhenFindMaxUniqueLength_ThenReturnMaxUniqueLength(int[] numbers, int expected)
        {
            var removeDuplicates = new RemoveDuplicates();

            var results = removeDuplicates.FindMaxUniqueLength(numbers);

            Assert.That(results, Is.EqualTo(expected));
        }
    }
}