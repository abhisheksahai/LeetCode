﻿using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT12122023
    {
        [Test]
        public void IsPalindromeTest()
        {
            bool result = LC12122023.IsPalindrome(121);
        }

        [Test]
        public void LongestPalindromeTest()
        {
            var result = LC12122023.LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
        }

        [Test]
        public void MajorityElementTest()
        {
            var result1 = LC12122023.MajorityElementOptimised([2, 2, 1, 1, 1, 2, 2]);
            var result2 = LC12122023.MajorityElement([2, 2, 1, 1, 1, 2, 2]);
        }

        [Test]
        public void IntersectionTest()
        {
            var result = LC12122023.Intersection([1, 2, 2, 1], [2, 2]);
        }

        [Test]
        public void RotateTest()
        {
            var result = LC12122023.Rotate([1, 2, 3, 4, 5, 6, 7], 3);
        }
    }
}