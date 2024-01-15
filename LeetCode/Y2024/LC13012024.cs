namespace LeetCode.Y2024
{
    public class LC13012024
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/longest-k-unique-characters-substring0853/1
        /// i & j points to start index. j moves till we have size of dictionary less than equal to k moment dictionary size is more than k we move i and reduce frequency in dictionary. if frequency becomes 0 we remove key from dictionary
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int LongestKSubstr(string s, int k)
        {
            int j = 0, l = 0, result = -1;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dic.ContainsKey(ch))
                {
                    dic[ch] = dic[ch] + 1;
                }
                else
                {
                    dic.Add(ch, 1);
                }
                while (dic.Count > k)
                {
                    char remChar = s[l++];
                    dic[remChar] = dic[remChar] - 1;
                    if (dic[remChar] == 0)
                    {
                        dic.Remove(remChar);
                    }
                    j++;
                }
                if (dic.Count == k)
                {
                    result = Math.Max(result, i - j + 1);
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/maximum-subarray/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }

        /// <summary>
        /// https://leetcode.com/problems/sliding-window-maximum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int len = nums.Length;
            int i = 0, j = i + k - 1;
            List<int> result = [];
            while (j <= len - 1)
            {
                int max = Int32.MinValue;
                for (int t = i; t <= j; t++)
                {
                    max = Math.Max(max, nums[t]);
                }
                result.Add(max);
                i++;
                j++;
            }
            return result.ToArray();
        }

        public static int[] MaxSlidingWindowOptimised(int[] nums, int k)
        {
            int len = nums.Length;
            int i = 0, j = 0;
            List<int> queue = [];
            List<int> ans = [];
            if (k >= len)
            {
                ans.Add(nums.Max());
                return [.. ans];
            }
            while (j < len)
            {
                while (queue.Count > 0 && queue[^1] < nums[j])
                {
                    queue.RemoveAt(queue.Count - 1);
                }
                queue.Add(nums[j]);
                if (j - i + 1 < k)
                {
                    j++;
                }
                else if (j - i + 1 == k)
                {
                    ans.Add(queue[0]);
                    if (nums[i] == queue[0])
                    {
                        queue.RemoveAt(0);
                    }
                    i++;
                    j++;
                }
            }
            return [.. ans];
        }
    }
}