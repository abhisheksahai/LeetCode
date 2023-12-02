using System.Linq;

namespace LeetCode
{
    public class LC02122023
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> map = [];
            for (int i = 0; i < len; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    return [map[diff], i];
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}