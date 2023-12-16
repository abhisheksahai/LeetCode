namespace LeetCode
{
    public class LC12122023
    {
        /// <summary>
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            int y = x, z = 0;
            while (y > 0)
            {
                z = z * 10 + y % 10;
                y = y / 10;
            }
            return x == z;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> result = new();
            HashSet<int> elements = new();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!elements.Contains(nums1[i]))
                {
                    elements.Add(nums1[i]);
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (elements.Contains(nums2[i]) && !result.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }
            return [.. result];
        }

        public static int LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return 1;
            int result = 0;
            HashSet<char> chars = new();
            foreach (char ch in s)
            {
                if (chars.Contains(ch))
                {
                    chars.Remove(ch);
                    result += 2;
                }
                else
                {
                    chars.Add(ch);
                }
            }
            result = chars.Count() != 0 ? result + 1 : result;
            return result;
        }

        public static int Test()
        {
            int result = 0;
            return result;
        }
    }
}