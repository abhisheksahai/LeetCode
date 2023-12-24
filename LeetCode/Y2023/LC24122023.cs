namespace LeetCode.Y2023
{
    public class LC24122023
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            Array.Sort(nums);
            if (len < 3 || nums[0] > 0)
            {
                return res;
            }
            if (len == 3)
            {
                if (nums[0] + nums[1] + nums[2] == 0)
                {
                    res.Add(new int[] { nums[0], nums[1], nums[2] });
                }
                return res;
            }
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int low = i + 1;
                int high = len - 1;
                int sum = 0;
                while (low < high)
                {
                    sum = nums[i] + nums[low] + nums[high];
                    if (sum > 0)
                    {
                        high--;
                    }
                    else if (sum < 0)
                    {
                        low++;
                    }
                    else
                    {
                        res.Add(new int[] { nums[i], nums[low], nums[high] });
                        int lastLowOccurance = nums[low], lastHighOccurance = nums[high];
                        while (low < high && lastLowOccurance == nums[low])
                        {
                            low++;
                        }
                        while (low < high && lastHighOccurance == nums[high])
                        {
                            high--;
                        }
                    }
                }
            }
            return res;
        }
    }
}