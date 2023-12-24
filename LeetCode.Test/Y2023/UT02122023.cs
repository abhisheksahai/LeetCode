using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT02122023
    {
        [Test]
        public void TwoSumTest()
        {
            var resul2 = LC02122023.TwoSum([3, 3], 6);
            var result1 = LC02122023.TwoSumWithTwoLoops([2, 7, 11, 15], 9);
            var result = LC02122023.TwoSum([2, 7, 11, 15], 9);
            Assert.That(result, Is.Not.Null);
            result = LC02122023.TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void TwoSumRetBoolTest()
        {
            var resul2 = LC02122023.TwoSumTwoPointer([2, 7, 11, 15], 9);
        }

        [Test]
        public void AddNumberTest()
        {
            var result = LC02122023.AddNumber(1, 5);
        }

        [Test]
        public void PrintStarTest()
        {
            LC02122023.PrintStar(5);
        }

        [Test]
        public void MinMaxArrayTest()
        {
            LC02122023.MinMaxArray([1, 100, -90, 23, 1000, -90, -1000]);
            LC02122023.MinMaxArray([1]);
        }

        [Test]
        public void PrintTriangleStarTest()
        {
            LC02122023.PrintTriangleStar(5);
        }

        [Test]
        public void FirtSecondThirdMaxTest()
        {
            LC02122023.FirtSecondThirdMax([1, 2, 3, 9, 11, -90, 11, 200, -99, -1000, 500, 100]);
        }
    }
}