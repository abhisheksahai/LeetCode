namespace LeetCode.Y2024
{
    public class LC14012024
    {
        public static int[] ConvertDecimalToBinary(int num)
        {
            Stack<int> stack = [];
            while (num > 0)
            {
                int rem = num % 2;
                stack.Push(rem);
                num /= 2;
            }
            return stack.ToArray();
        }

        /// <summary>
        /// https://leetcode.com/problems/missing-number/
        /// Tc=O(n) and SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumber(int[] nums)
        {
            int xorProduct = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xorProduct = xorProduct ^ nums[i];
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                xorProduct = xorProduct ^ i;
            }
            return xorProduct;
        }
    }
}