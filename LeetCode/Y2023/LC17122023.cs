namespace LeetCode.Y2023
{
    public class LC17122023
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            else if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                {
                    return new int[] { nums[0] };
                };
                return nums;
            }
            HashSet<int> result = new();
            Dictionary<int, int> map = new();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                    if (map[num] > nums.Length / 3 && !result.Contains(num))
                    {
                        result.Add(num);
                    }
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// https://leetcode.com/problems/majority-element-ii/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> MajorityElementMooreVoting(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            else if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                {
                    return new int[] { nums[0] };
                };
                return nums;
            }

            int? firstMajorityElement = null, secondMajorityElement = null, firstMajorityCount = 0, secondMajorityCount = 0;
            foreach (int num in nums)
            {
                if (firstMajorityElement.HasValue && num == firstMajorityElement)
                {
                    firstMajorityCount++;
                }
                else if (secondMajorityElement.HasValue && num == secondMajorityElement)
                {
                    secondMajorityCount++;
                }
                else if (firstMajorityCount == 0)
                {
                    firstMajorityElement = num;
                    firstMajorityCount = 1;
                }
                else if (secondMajorityCount == 0)
                {
                    secondMajorityElement = num;
                    secondMajorityCount = 1;
                }
                else
                {
                    firstMajorityCount--;
                    secondMajorityCount--;
                }
            }
            IList<int> result = new List<int>();
            if (nums.Count(n => n == firstMajorityElement) > nums.Length / 3)
            {
                result.Add(firstMajorityElement.Value);
            }
            if (nums.Count(n => n == secondMajorityElement) > nums.Length / 3)
            {
                result.Add(secondMajorityElement.Value);
            }
            return result;
        }
    }
}