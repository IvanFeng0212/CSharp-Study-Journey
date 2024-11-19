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
    }
}