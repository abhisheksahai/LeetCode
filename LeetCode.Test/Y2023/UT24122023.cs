using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT24122023
    {
        [Test]
        public void ThreeSumTest()
        {
            var res1 = LC24122023.ThreeSum([-1, 0, 1, 2, -1, -4]);
            var res2 = LC24122023.ThreeSum([0, 0, 0, 0]);
        }

        [Test]
        public void ThreeSumClosestTest()
        {
            var result1 = LC24122023.ThreeSumClosest([-1, 2, 1, -4], 1);
            var result2 = LC24122023.ThreeSumClosest([1, 1, 1, 1], 4);
        }

        [Test]
        public void FourSumTest()
        {
            var result1 = LC24122023.FourSum([1000000000, 1000000000, 1000000000, 1000000000], -294967296);
            var result2 = LC24122023.FourSum([2, 2, 2, 2, 2], 8);
            var result3 = LC24122023.FourSum([1, 0, -1, 0, -2, 2], 0);
        }
    }
}