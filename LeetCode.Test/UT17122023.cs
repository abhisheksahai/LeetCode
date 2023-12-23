namespace LeetCode.Test
{
    public class UT17122023
    {
        [Test]
        public void GetRowTest()
        {
            var result = LC17122023.GetRow(3);
        }

        [Test]
        public void MaxProfitTest()
        {
            var result1 = LC17122023.MaxProfit([7, 1, 5, 3, 2, 10]);
            var result2 = LC17122023.MaxProfit([7, 1, 5, 3, 6, 4]);
        }

        [Test]
        public void MajorityElementTest()
        {
            var result1 = LC17122023.MajorityElementMooreVoting([2, 2, 1, 3]);
            var result2 = LC17122023.MajorityElement([3, 2, 3]);
        }
    }
}