using System;
using Xunit;

namespace Easy.Tests
{
    public class TwoSumExercisesTests
    {
        [Fact]
        public void TwoSum_ArrayContainingTarget_ReturnsExpectedResult()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var twoSumExercises = new TwoSumExercises();

            var expected = new int[] { 0, 1 };
            var result = twoSumExercises.TwoSum(nums, target);
            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSum_TargetNotFound_ThrowsException()
        {
            var nums = new int[] { 0, 1, 2, 3 };
            var target = 9;
            var twoSumExercises = new TwoSumExercises();
            
            Assert.Throws<ArgumentException>(() => twoSumExercises.TwoSum(nums, target));
        }
    }
}
