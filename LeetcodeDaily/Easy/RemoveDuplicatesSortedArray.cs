using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public static class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums is null) return 0;
            var numList = nums.ToList();
            var key = int.MaxValue;

            foreach (var item in nums)
            {
                if (item == key)
                {
                    numList.Remove(item);
                }
                else
                {
                    key = item;
                    continue;
                }
            }

            numList.ToArray().CopyTo(nums, 0);
            return numList.Count;
        }
    }
}
