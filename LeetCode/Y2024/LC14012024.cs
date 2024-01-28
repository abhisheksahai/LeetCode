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

        public static int LeftShift(int num, int k)
        {
            for (int i = 1; i <= k; i++)
            {
                num <<= 1;
            }
            return num;
        }

        public static bool IsKBitSetForNumber(int num, int k)
        {
            int mask = 1 << (k - 1);
            int result = num & mask;
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public static int SetKBitForNumber(int num, int k)
        {
            int mask = 1 << (k - 1);
            num = num | mask;
            return num;
        }

        public static int ClearKBit(int num, int k)
        {
            int mask = 1 << (k - 1);
            mask = (~mask);
            num = num & mask;
            return num;
        }

        public static int PositionRightmostSetbit(int num)
        {
            if (num == 0) return 0;
            int m = 1, position = 1;
            while ((num & m) == 0)
            {
                m = 1 << m;
                position++;
            }
            return position;
        }

        public static int CountNumberOfSetBits(int num)
        {
            if (num == 0) return 0;
            int count = 0;
            while (num > 0)
            {
                int p = num & 1;
                if (p != 0)
                {
                    count++;
                }
                num = num >> 1;
            }
            return count;
        }


        /// <summary>
        /// https://leetcode.com/problems/single-number-iii/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }

        public static double MyPow(double x, int n)
        {
            double result = 0;

            return result;
        }


        /// <summary>
        /// https://leetcode.com/problems/power-of-two/
        /// TC=O(logN) and SC=
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            if (n % 2 == 0)
            {
                return IsPowerOfTwo(n / 2);
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/count-good-numbers/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountGoodNumbers(long n)
        {
            int result = 0;
            return result;
        }



    }
}