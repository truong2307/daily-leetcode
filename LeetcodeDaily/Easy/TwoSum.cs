using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum
    /// </summary>
    public static class TwoSumLeetCode
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            if (nums.Length < 1) return new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsValue(target - nums[i])) return new int[] { dictionary.FirstOrDefault(x => x.Value == target - nums[i]).Key, i };
                dictionary.Add(i,nums[i]);
            }

            return new int[2];
        }
    }
}
