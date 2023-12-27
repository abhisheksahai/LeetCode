namespace LeetCode.Y2023
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

        /// <summary>
        /// https://leetcode.com/problems/longest-palindrome/description/
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
        /// https://leetcode.com/problems/majority-element/description/
        /// TC=O(n) and SC=O(n) because of Dictionary
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

        //Moore Voting Algorithm. This algorithm is applicable to this problem only.
        //Majority = first element and count =1, loop from second element to end. if current element = majority element increment the count else decrement the count.When count reaches 0, change the majority to current elemnet and set count to 1
        //TC=O(n) and SC=O(1)
        public static int MajorityElementOptimised(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int majority = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == majority)
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        majority = nums[i];
                        count = 1;
                    }
                }
            }
            return majority;
        }

        /// <summary>
        /// https://leetcode.com/problems/intersection-of-two-arrays/
        /// TC=O(n) and Sc=O(n)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
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
       
        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// TC=O(N) and SC=O(N)
        /// Assignment
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static int[] Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            if (k >= len)
            {
                k %= len;
            }
            if (k == 0 || len == 1)
            {
                return nums;
            }
            int[] result = new int[len];
            int index = len - k;
            result[0] = nums[index];
            for (int i = 1; i < len; i++)
            {
                index++;
                if (index == len)
                {
                    index = 0;
                }
                result[i] = nums[index];
            }
            Array.Copy(result, nums, len);
            return result;
        }
    }
}