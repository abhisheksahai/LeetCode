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
    }
}