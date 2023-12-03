namespace LeetCode.Test
{
    public class UT03122023
    {
        [Test]
        public void ElementsValueEqualToIndexTest()
        {
            var result = LC03122023.ElementsValueEqualToIndex([15, 2, 45, 12, 7]);
        }

        [Test]
        public void PerFectArrayTest()
        {
            LC03122023.PerFectArray([1, 2, 3, 2, 1]);
        }

        [Test]
        public void RemoveAllMaximumMinimumTest()
        {
            int result = LC03122023.RemoveAllMaximumMinimum([7, 8, 3, 4, 2, 9, 5]);
        }
    }
}