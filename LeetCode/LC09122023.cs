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

        public static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static int MinOfThree(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public static int MidOfThree(int a, int b, int c)
        {
            if (a > b && a < c || a > c && a < b)
                return a;
            if (b > c && b < a || b > a && b < c)
                return b;
            return c;
        }

        public static void PrintNumberSeries(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                int counter = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter++);
                }
                Console.WriteLine();
            }
        }

        public static void PrintReverseNumberSeries(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                int counter = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter++);
                }
                Console.WriteLine();
            }
        }

        public static int[] ReturnOddElements(int[] nums)
        {
            IList<int> result = new List<int>();
            foreach (var num in nums)
            {
                if (num % 2 == 1)
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }

        public static int SumOfElement(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
                result += num;
            }
            return result;
        }
    }
}