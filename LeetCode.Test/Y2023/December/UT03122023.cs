using LeetCode.Y2023.December;

namespace LeetCode.Test.Y2023.December
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

        [Test]
        public void FascinatingTest()
        {
            bool valid = LC03122023.Fascinating(192);
            bool invalid = LC03122023.Fascinating(853);
        }

        [Test]
        public void PrintNumberTriangleTest()
        {
            LC03122023.PrintNumberTriangle(5);
        }

        [Test]
        public void ReverseNumberTest()
        {
            int result = LC03122023.ReverseNumber(121);
        }
    }
}