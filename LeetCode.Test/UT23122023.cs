namespace LeetCode.Test
{
    public class UT23122023
    {
        [Test]
        public void FirstUniqCharTest()
        {
            var result = LC23122023.FirstUniqChar("loveleetcode");
        }

        [Test]
        public void IsAnagramTest()
        {
            var result = LC23122023.IsAnagram("anagram", "nagaram");
        }

        [Test]
        public void LengthOfLongestSubstringTest()
        {
            var result3 = LC23122023.LengthOfLongestSubstring("dvdf");
            var result2 = LC23122023.LengthOfLongestSubstring("au");
            var result1 = LC23122023.LengthOfLongestSubstring("pwwkew");
        }

        [Test]
        public void LongestPalindromeTest()
        {
            var result = LC23122023.LongestPalindrome("dccaccd");
        }
    }
}