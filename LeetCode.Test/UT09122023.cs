namespace LeetCode.Test
{
    public class UT09122023
    {
        [Test]
        public void MergeTwoSortedArrayTest()
        {
            var result1 = LC09122023.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
            var result2 = LC09122023.Merge([1], 1, [], 0);
        }

        [Test]
        public void FizzBuzzTest()
        {
            var result = LC09122023.FizzBuzz(15);
        }
    }
}