﻿namespace LeetCode.Y2023.December
{
    public class LC02122023
    {
        public static int AddNumber(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void PrintStar(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void MinMaxArray(int[] nums)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            if (nums == null || nums.Length == 0)
            {
                Console.WriteLine($"Array is empty");
                return;
            }
            if (nums.Length == 1)
            {
                max = min = nums[0];
                Console.WriteLine($"Min {min} and Max {max}");
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            Console.WriteLine($"Min {min} and Max {max}");
        }

        public static void PrintTriangleStar(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                string str = string.Empty;
                for (int j = 0; j < num - i; j++)
                {
                    str = $" {str}";
                }
                for (int j = 1; j <= i; j++)
                {
                    str = $"{str}* ";
                }
                Console.WriteLine(str);
            }
        }

        public static void FirtSecondThirdMax(int[] nums)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > first)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                }
                else if (nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (nums[i] > third)
                {
                    third = nums[i];
                }
            }
            Console.WriteLine($"First max {first}, second max {second} and third max {third}");
        }
    }
}