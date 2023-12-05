namespace LeetCode.Test
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
        public void GeneratePascalTraingleTest()
        {
            var result = LC04122023.GeneratePascalTraingle(5);
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
    }
}