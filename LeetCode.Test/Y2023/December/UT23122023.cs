using LeetCode.Y2023.December;

namespace LeetCode.Test.Y2023.December
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

        [Test]
        public void RotateTest()
        {
            var result = LC23122023.Rotate([1, 2, 3, 4, 5, 6, 7], 3);
        }

        [Test]
        public void convertToWaveTest()
        {
            LC23122023.convertToWave(5, [1, 2, 3, 4, 5]);
        }

        [Test]
        public void MergeTest()
        {
            var result = LC23122023.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        }
    }
}