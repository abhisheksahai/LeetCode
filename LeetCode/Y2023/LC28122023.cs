namespace LeetCode.Y2023
{
    public class LC28122023
    {
        /// <summary>
        /// https://leetcode.com/problems/move-zeroes
        /// TC=O(N), SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            if (nums is null || nums.Length == 0) return;
            int k = 0, len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k++] = nums[i];
                }
            }
            while (k < len)
            {
                nums[k++] = 0;
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate/
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate-ii/
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int len = nums.Length;
            Dictionary<int, int> kv = new();
            for (int i = 0; i < len; i++)
            {
                if (kv.ContainsKey(nums[i]))
                {
                    if (i - kv[nums[i]] <= k)
                    {
                        return true;
                    }
                    kv[nums[i]] = i;
                }
                else
                {
                    kv.Add(nums[i], i);
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/summary-ranges/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new();
            if (nums == null || nums.Length == 0)
            {
                return result;
            }
            int i = 0, j = 0, len = nums.Length;
            while (i < len - 1)
            {
                if (nums[i + 1] - nums[i] == 1)
                {
                    i++;
                }
                else
                {
                    if (i == j)
                    {
                        result.Add($"{nums[i]}");
                    }
                    else
                    {
                        result.Add($"{nums[j]}->{nums[i]}");
                    }
                    j = ++i;
                }
            }
            if (i == j)
            {
                result.Add($"{nums[i]}");
            }
            else
            {
                result.Add($"{nums[j]}->{nums[i]}");
            }
            return result;
        }
    }
}