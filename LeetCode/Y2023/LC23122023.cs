using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Y2023
{
    public class LC23122023
    {

        /// <summary>
        /// https://leetcode.com/problems/first-unique-character-in-a-string/description/
        /// TC= O(N) and SC=O(1) because we are storing small alphabets and in worst case it will have 26 elements which is less than 100
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> chars = new();
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], 1);
                }
                else
                {
                    chars[s[i]]++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (chars[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// https://leetcode.com/problems/valid-anagram/description/
        /// Tc=O(N) and SC=O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> chars = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], 1);
                }
                else
                {
                    chars[s[i]]++;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (chars.ContainsKey(t[i]))
                {
                    if (chars[t[i]] > 1)
                    {
                        chars[t[i]]--;
                    }
                    else
                    {
                        chars.Remove(t[i]);
                    }
                }
                else
                {
                    return false;
                }
            }
            return chars.Count == 0;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
        /// Using sliding window. initally i = j =0. both will move from L->R. i will increment when char is added to hasset and j will be incremented when we remove character from hashset
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int n = s.Length;
            int i = 0, j = 0, max = 0;
            HashSet<char> hSet = new();
            while (i < n)
            {
                if (!hSet.Contains(s[i]))
                {
                    hSet.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, hSet.Count);
                    hSet.Remove(s[j]);
                    j++;
                }
                max = Math.Max(max, hSet.Count);
            }
            return max;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-palindrome/description/
        /// (n-1)a+(m-1)b+1 => Formula to take odd characters
        /// TC=O(N) and SC=O(1). SC=O(1) because as input contains upper and lower case letters only so maximum it will have 26+26 keys in the dictionary.
        /// Create Frequency for each character.Even number of characters can be taken as it is as these can be partition in 2 halves.For odd number of characters take n-1 characters and add 1 at the end if we encounter any odd character
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
            Dictionary<char, int> frequency = new();
            foreach (char ch in s)
            {
                if (frequency.ContainsKey(ch))
                {
                    frequency[ch]++;
                }
                else
                {
                    frequency[ch] = 1;
                }
            }
            bool oddFrequeny = false;
            foreach (var kv in frequency)
            {
                if (kv.Value % 2 == 0)
                {
                    result += kv.Value;
                }
                else
                {
                    oddFrequeny = true;
                    result += kv.Value - 1;
                }
            }
            if (oddFrequeny)
            {
                result++;
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// Rever n-k starting element. Reverse k end elements. Reverse entire array. Array.Reverse has time complexity of O(N) depending on the number of elements
        /// TC=O(N) and SC=O(1)
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
            Array.Reverse(nums, 0, len - k);
            Array.Reverse(nums, len - k, k);
            Array.Reverse(nums, 0, len);
            return nums;
        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/problems/wave-array-1587115621/1
        /// TC = O(N) and SC=O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="arr"></param>
        public static void convertToWave(int n, List<int> arr)
        {
            for (int i = 0; i < n - 1; i = i + 2)
            {
                arr[i] = arr[i] + arr[i + 1];
                arr[i + 1] = arr[i] - arr[i + 1];
                arr[i] = arr[i] - arr[i + 1];
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0, j = 0, k = 0;
            int[] nums3 = new int[m + n];
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3[k++] = nums1[i++];
                }
                else
                {
                    nums3[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                nums3[k++] = nums1[i++];
            }
            while (j < n)
            {
                nums3[k++] = nums2[j++];
            }
            Array.Copy(nums3, nums1, m + n);
            return nums1;
        }
    }
}
