namespace LeetCode.Y2023
{
    public class LC06012024
    {
        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] MergeOptimised(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            for (int p = n + m - 1; p < 0; p--)
            {

            }
            return nums1;
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
        /// Salesforce, MS
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[][] Merge(int[][] intervals)
        {
            return intervals;
        }
    }
}