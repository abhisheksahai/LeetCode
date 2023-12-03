namespace LeetCode
{
    public static class LC03122023
    {
        public static int[] ElementsValueEqualToIndex(int[] nums)
        {
            List<int> result = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i + 1)
                {
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }

        public static void PerFectArray(int[] nums)
        {
            int len = nums.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (nums[i] != nums[len - 1 - i])
                {
                    Console.WriteLine("Not perfect");
                    return;
                }
            }
            Console.WriteLine("Perfect");
        }

        public static int RemoveAllMaximumMinimum(int[] nums)
        {
            List<int> result = [];
            for (int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[i]);
            }
            while (result.Count > 1)
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] < min)
                    {
                        min = result[i];
                    }
                    if (result[i] > max)
                    {
                        max = result[i];
                    }
                }
                result.Remove(min);
                result.Remove(max);
            }
            Console.WriteLine($"{result[0]}");
            return result[0];
        }

        public static bool Fascinating(int num)
        {
            if (num <= 99)
            {
                return false;
            }
            string numStr = $"{num}{num * 2}{num * 3}";
            if (numStr.Length != 9)
            {
                return false;
            }
            HashSet<string> result = [];
            for (int i = 0; i < numStr.Length; i++)
            {
                result.Add(numStr[i].ToString());
            }
            if (result.Count != 9 || result.Contains("0"))
            {
                return false;
            }
            return true;
        }
    }
}