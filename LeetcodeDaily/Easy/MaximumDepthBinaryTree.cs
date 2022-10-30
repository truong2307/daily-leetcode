using LeetcodeDaily.Models;
using System;

namespace LeetcodeDaily.Easy
{
    public static class MaximumDepthBinaryTree
    {
        public static int MaxDepth(TreeNode root) => root == null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}
