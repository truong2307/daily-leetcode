using LeetcodeDaily.Models;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree
    /// </summary>
    public static class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root is null) return true;

            var stackNodeLeft = new Stack<TreeNode>();
            var stackNodeRight = new Stack<TreeNode>();

            stackNodeLeft.Push(root);
            stackNodeRight.Push(root);

            while (stackNodeLeft.Any() && stackNodeRight.Any())
            {
                if (stackNodeLeft.Peek().left != null && stackNodeRight.Peek().right != null)
                {
                    stackNodeLeft.Push(stackNodeLeft.Peek().left);
                    stackNodeRight.Push(stackNodeRight.Peek().right);

                    if (stackNodeLeft.Peek().val != stackNodeRight.Peek().val) return false;
                }
                else
                {
                    while (stackNodeLeft.Any() && stackNodeRight.Any())
                    {
                        var curLeftNode = stackNodeLeft.Pop();
                        var curRightNode = stackNodeRight.Pop();
                        switch (true)
                        {
                            case true when curLeftNode.left != null ^ curRightNode.right != null:
                            case true when curLeftNode.right != null ^ curRightNode.left != null:
                            case true when curLeftNode.val != curRightNode.val:
                                return false;

                            default:
                                break;
                        }
                        if (curLeftNode.right != null && curRightNode.left != null)
                        {
                            stackNodeLeft.Push(curLeftNode.right);
                            stackNodeRight.Push(curRightNode.left);
                            break;
                        }
                    }
                }
            }


            return true;
        }
    }
}
