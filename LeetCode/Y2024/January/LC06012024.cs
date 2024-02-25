namespace LeetCode.Y2024.January
{
    public class LC06012024
    {
        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="nums1"></param> 
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            for (int p = n + m - 1; p >= 0; p--)
            {
                if (p2 < 0)
                {
                    break;
                }
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// TC=O(N^2) and SC=O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaBruteForce(int[] height)
        {
            int maxArea = 0;
            for (int p = 0; p < height.Length; p++)
            {
                for (int p1 = p + 1; p1 < height.Length; p1++)
                {
                    int currentArea = Math.Min(height[p], height[p1]) * (p1 - p);
                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
            return maxArea;
        }

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// Here two pointer is used even if array is not sorted.
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaTwoPointer(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int currentArea = currentHeight * width;
                maxArea = Math.Max(maxArea, currentArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }

        /// <summary>
        /// https://leetcode.com/problems/merge-intervals/
        /// TC=O(N) and SC=O(N)
        /// Salesforce,MS,Amazon
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            List<int[]> result = [];
            result.Add(intervals[0]);
            for (int i = 1; i < intervals.Length; i++)
            {
                int lastCount = result.Count - 1;
                if (result[lastCount][1] >= intervals[i][0])
                {
                    result[lastCount][1] = Math.Max(intervals[i][1], result[lastCount][1]);
                }
                else
                {
                    result.Add(intervals[i]);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// https://leetcode.com/problems/product-of-array-except-self
        /// Approach : for index i the value will product of its left element * product of its right element
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] left = new int[len];
            int[] right = new int[len];
            int temp = 1;
            left[0] = 1;
            for (int i = 1; i < len; i++)
            {
                temp = temp * nums[i - 1];
                left[i] = temp;
            }
            temp = 1;
            right[len - 1] = 1;
            for (int i = len - 2; i > 0; i--)
            {
                temp = temp * nums[i + 1];
            }
            return left;

        }

        /// <summary>
        /// https://leetcode.com/problems/trapping-rain-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int Trap(int[] height)
        {
            int result = 0;
            int len = height.Length;
            int[] leftMax = new int[len];
            int[] rightMax = new int[len];
            leftMax[0] = height[0];

            for (int i = 1; i < len; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[len - 1] = height[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            for (int i = 0; i < len; i++)
            {
                result += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }
            return result;
        }

    }
}