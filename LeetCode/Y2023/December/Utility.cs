﻿namespace LeetCode.Y2023.December
{
    public class Utility
    {
        public static void SwapNumber(ref int a, ref int b)
        {
            if (a < b)
            {
                a += b;
                b = a - b;
                a -= b;
            }
        }
    }
}
