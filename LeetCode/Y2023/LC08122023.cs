namespace LeetCode.Y2023
{
    public class LC08122023
    {
        public static int MinOfThreeNumbers(int x, int y, int z)
        {
            int result = x > y ? x : y;
            result = result > z ? result : z;
            return result;
        }

        public static int MinOfThreeNum(int x, int y, int z)
        {
            return Math.Max(Math.Max(x, y), z);
        }

        public static void CoupleEligibleForMarriage(int girlAge, int boysAge)
        {
            bool result = girlAge >= 18 && boysAge >= 21;
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static void TaxAmount(int billAmount)
        {
            var tax = billAmount > 50000 ? billAmount * .10 : billAmount * .05;
            Console.WriteLine($"Tax amount {tax}");
        }

        public static bool IsLeap(int year)
        {
            if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        public static void OddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}