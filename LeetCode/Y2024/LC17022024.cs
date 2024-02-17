namespace LeetCode.Y2024
{

    /// <summary>
    /// Binary search
    /// </summary>
    public class LC17022024
    {
        /// <summary>
        /// https://leetcode.com/problems/binary-search/
        /// Tc=O(logn) and SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search(int[] nums, int target)
        {
            int low, mid, high;
            low = 0;
            high = nums.Length - 1;
            while (low <= high)
            {
                //Below formula will overcome issue of integer out of range
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/first-and-last-occurrences-of-x2041/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] FirstAndLast(int[] arr, int n, int x)
        {
            int[] result = new int[2];
            result = [FindFirst(arr, n, x), FindLast(arr, x, x)];
            return result;
        }

        public static int FindFirst(int[] arr, int n, int x)
        {
            int low = 0, mid = 0, high = n - 1, result = -1;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    high = mid - 1;
                    result = mid;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        public static int FindLast(int[] arr, int n, int x)
        {
            int low = 0, mid = 0, high = n - 1, result = -1;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    low = mid + 1;
                    result = mid;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }


        //Find frquency of numbers in sorted array
        //https://www.geeksforgeeks.org/problems/number-of-occurrence2259/1?utm_source=geeksforgeeks&utm_medium=article_practice_tab&utm_campaign=article_practice_tab

    }
}