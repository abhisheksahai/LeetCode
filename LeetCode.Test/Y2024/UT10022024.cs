using LeetCode.Y2024;

namespace LeetCode.Test.Y2024
{
    public class UT10022024
    {
        [Test]
        public void ReverseStringTest()
        {
            LC10022024.ReverseString(['h', 'e', 'l', 'l', 'o']);
        }

        [Test]
        public void IsValidTest()
        {
            var result1 = LC10022024.IsValid("({[]})");
            var result2 = LC10022024.IsValid("()");
        }
    }
}