using static LeetCode.Y2023.December.LC28122023;

namespace LeetCode.Test.Y2023.December
{
    public class UT28122023
    {
        [Test]
        public void MoveZeroesTest()
        {
            MoveZeroes([0, 1, 0, 3, 12]);
        }

        [Test]
        public void ContainsDuplicateTest()
        {
            var result = ContainsDuplicate([1, 2, 3, 1]);
        }

        [Test]
        public void ContainsNearbyDuplicateTest()
        {
            var result1 = ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2);
            var result2 = ContainsNearbyDuplicate([1, 2, 3, 1], 3);
            var result3 = ContainsNearbyDuplicate([1, 0, 1, 1], 1);
        }

        [Test]
        public void SummaryRangesTest()
        {
            var result1 = SummaryRanges([0, 1, 2, 4, 5, 7]);
            var result2 = SummaryRanges([0, 2, 3, 4, 6, 8, 9]);
        }

        [Test]
        public void NumArrayTest()
        {
            NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
            var result = numArray.SumRange(0, 2);
        }

        [Test]
        public void NumMatrixTest()
        {
            NumMatrix matrix = new NumMatrix([[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]);
            var result = matrix.SumRegion(2, 1, 4, 3);
        }

        [Test]
        public void RemoveElementTest()
        {
            var result = RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
        }

        [Test]
        public void IntersectionTest()
        {
            var result = Intersection([1, 2, 2, 1], [2, 2]);
        }

        [Test]
        public void IntersectTest()
        {
            var result = Intersect([4, 9, 5], [9, 4, 9, 8, 4]);
        }

        [Test]
        public void NextGreaterElementTest()
        {
            var resul1 = NextGreaterElement([1, 3, 5, 2, 4], [6, 5, 4, 3, 2, 1, 7]);
            var resul2 = NextGreaterElement([4, 1, 2], [1, 3, 4, 2]);
        }
    }
}