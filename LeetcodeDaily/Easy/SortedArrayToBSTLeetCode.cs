using System;
using System.Collections.Generic;

namespace LeetcodeDaily.Easy
{
    public class SortedArrayToBSTLeetCode
    {
        public static TreeNode SortedArrayToBST(int[] nums) 
            => nums is null || nums.Length < 0 ? null : Helper(nums, 0, nums.Length - 1);

        private static TreeNode Helper(int[] nums, int left, int right)
        {
            if (left > right) return null;
           
            var mid = (left + right) / 2;
            var rs = new TreeNode
            {
                val = nums[mid],
                left = Helper(nums, left, mid - 1),
                right = Helper(nums, mid + 1, right)
            };

            return rs;
        }
    }
}
