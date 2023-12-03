namespace LeetCode
{
    public static class LC03122023
    {
        public static int[] ElementsValueEqualToIndex(int[] nums)
        {
            List<int> result = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i + 1)
                {
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }
    }
}