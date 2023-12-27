using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT17122023
    {
        [Test]
        public void MajorityElementTest()
        {
            var result1 = LC17122023.MajorityElementMooreVoting([2, 2, 1, 3]);
            var result2 = LC17122023.MajorityElement([3, 2, 3]);
        }
    }
}