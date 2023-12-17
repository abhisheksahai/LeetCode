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

        /// <summary>
        /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        /// TC = O(n) and SC = O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            while (startIndex < endIndex)
            {
                int sum = numbers[startIndex] + numbers[endIndex];
                if (sum == target)
                {
                    return new int[] { startIndex + 1, endIndex + 1 };
                }
                else if (sum > target)
                {
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            throw new Exception("No integer pair exists");
        }

        /// <summary>
        /// https://leetcode.com/problems/majority-element/description/
        /// TC=O(n) and SC=O(n) because of dictinary
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            Dictionary<int, int> keyValuePairs = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i])) 
                {
                    keyValuePairs[nums[i]]++;
                    if (keyValuePairs[nums[i]] > nums.Length / 2)
                    {
                        return nums[i];
                    }
                }
                else
                {
                    keyValuePairs.Add(nums[i], 1);
                }
            }
            return int.MinValue;
        }
    }
}