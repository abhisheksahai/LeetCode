﻿using LeetCode.Y2024;

namespace LeetCode.Test.Y2024
{
    public class UT13012024
    {
        [Test]
        public void LongestKSubstrTest()
        {
            var result = LC13012024.LongestKSubstr("aabacbebebe", 3);
        }

        [Test]
        public void MaxSlidingWindowTest()
        {
            var result = LC13012024.MaxSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3);
        }
    }
}