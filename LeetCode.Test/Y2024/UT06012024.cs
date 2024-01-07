using LeetCode.Y2023;

namespace LeetCode.Test.Y2024
{
    public class UT06012024
    {
        [Test]
        public void MergeOptimisedTest()
        {
            LC06012024.Merge([2, 0], 1, [1], 1);
            LC06012024.Merge([0], 0, [1], 1);
            LC06012024.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        }

        [Test]
        public void MaxAreaTwoPointerTest()
        {
            var result1 = LC06012024.MaxAreaTwoPointer([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            var result2 = LC06012024.MaxAreaBruteForce([1, 8, 6, 2, 5, 4, 8, 3, 7]);
        }

        [Test]
        public void MergeTest()
        {
            var result = LC06012024.Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);
        }

    }
}