using LeetcodeDaily.Models;
using System;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/balanced-binary-tree/
    /// </summary>
    public static class BalancedBinaryTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root is null) return true;

            int leftHeigth = MaximumDepthBinaryTree.MaxDepth(root.left);
            int rightHeigth = MaximumDepthBinaryTree.MaxDepth(root.right);

            return Math.Abs(leftHeigth - rightHeigth) <= 1
                && IsBalanced(root.left)
                && IsBalanced(root.right);
        }
    }
}
