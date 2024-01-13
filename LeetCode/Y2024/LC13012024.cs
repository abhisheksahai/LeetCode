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
            int i = 0, j = 0;
            int result = 0;
            Dictionary<char, int> kv = new Dictionary<char, int>();
            while (j < s.Length - 1)
            {
                if (kv.ContainsKey(s[j]))
                {
                    kv[s[j]]++;
                }
                else
                {
                    if (kv.Count == k)
                    {
                        i++;

                    }
                    else
                    {
                        result = Math.Max(result, j - i + 1);
                        kv.Add(s[j], 1);
                    }
                }
                j++;

            }

            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/maximum-subarray/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            return 0;
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
            int i = 0, j = 0, temp = nums[0];
            List<int> result = [];
            while (j <= len - 1)
            {
                temp=Math.Max(temp, nums[j]);
                i++;
                j++;
            }
            return result.ToArray();
        }


    }
}