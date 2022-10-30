using LeetcodeDaily.Models;
using System;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public static class MinimumDepthOfBinaryTree
    {
        public static int MinDepth(TreeNode root) => true switch
        {
            true when root == null => 0,
            true when root.left is null && root.right is null => 1,
            true when root.left is null => MinDepth(root.right) + 1,
            true when root.right is null => MinDepth(root.left) + 1,
            _ => Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1,
        };
    }
}
