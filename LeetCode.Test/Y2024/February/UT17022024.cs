using LeetCode.Y2024.February;

namespace LeetCode.Test.Y2024.February
{
    public class UT17022024
    {
        [Test]
        public void FirstAndLastTest()
        {
            var result = LC17022024.FirstAndLast([1, 3, 3, 4], 4, 3);
        }

        [Test]
        public void CountTest()
        {
            int result1 = LC17022024.Count([10, 11], 2, 10);
            int result2 = LC17022024.Count([1, 1, 2, 2, 2, 2, 3, 5], 8, 4);
            int result3 = LC17022024.Count([1, 1, 2, 2, 2, 2, 3], 7, 4);
            int result4 = LC17022024.Count([1, 1, 2, 2, 2, 2, 3], 7, 2);
        }

        [Test]
        public void FindPeakElementTest()
        {
            var result1 = LC17022024.FindPeakElement([1, 2, 5, 4, 3, 2, 1, 2, 4]);
            var result2 = LC17022024.FindPeakElement([2, 1, 3]);
        }

        [Test]
        public void SearchInRotatedSortedArrayTest()
        {
            var result = LC17022024.SearchInRotatedSortedArray([4, 5, 6, 7, 0, 1, 2], 0);
        }

        [Test]
        public void SearchMatrixTest()
        {
            var result = LC17022024.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);
        }
    }
}