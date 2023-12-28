using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT28122023
    {
        [Test]
        public void MoveZeroesTest()
        {
            LC28122023.MoveZeroes([0, 1, 0, 3, 12]);
        }

        [Test]
        public void ContainsDuplicateTest()
        {
            var result = LC28122023.ContainsDuplicate([1, 2, 3, 1]);
        }

        [Test]
        public void ContainsNearbyDuplicateTest()
        {
            var result = LC28122023.ContainsNearbyDuplicate([1, 2, 3, 1], 3);
        }
    }
}