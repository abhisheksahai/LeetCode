using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT04122023
    {
        [Test]
        public void IsPalindromeTest()
        {
            LC04122023.IsPalindrome("121");
            LC04122023.IsPalindrome("madam");
        }

        [Test]
        public void IsPrimeTest()
        {
            bool result = LC04122023.IsPrime(23);
        }      

        [Test]
        public void MaximumWealthTest()
        {
            var result = LC04122023.MaximumWealth([[1, 2, 3], [1, 5], [99, 100]]);
        }

        [Test]
        public void RunningSumTest()
        {
            var result = LC04122023.RunningSum([1, 2, 3, 4]);
        }

        [Test]
        public void NumJewelsInStonesTest()
        {
            var result = LC04122023.NumJewelsInStones("aA", "aAAbbbb");
        }

        [Test]
        public void MinimumAbsDifferenceTest()
        {
            var result1 = LC04122023.MinimumAbsDifferenceWithSort([40, 11, 26, 27, -20]);
            var result2 = LC04122023.MinimumAbsDifference([4, 2, 1, 3]);
        }

        [Test]
        public void ThreeConsecutiveOddsTest()
        {
            var result = LC04122023.ThreeConsecutiveOdds([2, 6, 4, 1]);
        }

        [Test]
        public void MoveZeroesTest()
        {
            LC04122023.MoveZeroes([0, 1, 0, 3, 12]);
        }
    }
}