namespace LeetCode.Y2023
{
    public class LC24122023
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
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

        /// <summary>
        /// https://leetcode.com/problems/3sum-closest/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int len = nums.Length;
            if (len == 3)
            {
                return nums[0] + nums[1] + nums[2];
            }
            int diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                int low = i + 1;
                int high = len - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    int diffNew = Math.Abs(sum - target);
                    if (diffNew < Math.Abs(diff))
                    {
                        diff = sum - target;
                    }
                    if (sum < target)
                    {
                        low++;
                    }
                    else if (sum > target)
                    {
                        high--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return target + diff;
        }

        /// <summary>
        /// https://leetcode.com/problems/4sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result;
            }
            int len = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < len - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < len - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1, right = len - 1;
                    long sum = nums[i] + nums[j];
                    while (left < right)
                    {
                        long totalSum = sum + nums[left] + nums[right];
                        if (totalSum < target)
                        {
                            left++;
                        }
                        else if (totalSum > target)
                        {
                            right--;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}