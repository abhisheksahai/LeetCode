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
        public void LongestPalindromeConcatTwoLettersTest()
        {
            var result = LC12122023.LongestPalindromeConcatTwoLetters(["cc", "ll", "xx"]);
        }
    }
}