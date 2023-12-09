namespace LeetCode
{
    public class LC09122023
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0, j = 0, k = 0;
            int[] nums3 = new int[m + n];
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3[k++] = nums1[i++];
                }
                else
                {
                    nums3[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                nums3[k++] = nums1[i++];
            }
            while (j < n)
            {
                nums3[k++] = nums2[j++];
            }
            Array.Copy(nums3, nums1, m + n);
            return nums1;
        }

        public static IList<string> FizzBuzz(int n)
        {
            string[] result = new string[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = $"{i}";
                }
            }
            return result;
        }
    }
}