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
    }
}