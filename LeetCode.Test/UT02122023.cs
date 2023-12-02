namespace LeetCode.Test
{
    public class UT02122023
    {
        [Test]
        public void TwoSumTest()
        {
            var result = LC02122023.TwoSum([2, 7, 11, 15], 9);
            Assert.That(result, Is.Not.Null);
            result = LC02122023.TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11);
            Assert.That(result, Is.Not.Null);
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
    }
}