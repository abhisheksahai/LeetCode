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
            var result2 = LC24122023.ThreeSumClosest([1,1,1,1], 4);
        }
    }
}