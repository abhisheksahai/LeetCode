namespace LeetCode.Test
{
    public class UT12122023
    {
        [Test]
        public void IsPalindromeTest()
        {
            bool result = LC12122023.IsPalindrome(121);
        }

        [Test]
        public void IntersectionTest()
        {
            var result = LC12122023.Intersection([1, 2, 2, 1], [2, 2]);
        }

        [Test]
        public void LongestPalindromeTest()
        {
            var result = LC12122023.LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
        }

        [Test]
        public void TwoSumTest()
        {
            var result = LC12122023.TwoSum([2, 7, 11, 15], 9);
        }

        [Test]
        public void MajorityElementTest()
        {
            var result = LC12122023.MajorityElement([2, 2, 1, 1, 1, 2, 2]);
        }
    }
}