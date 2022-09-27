using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree/
    /// </summary>
    public class SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p is null && q is null) return true;
            if (p is null || q is null) return false;

            var pStackNode = new Stack<TreeNode>();
            var qStackNode = new Stack<TreeNode>();

            pStackNode.Push(p);
            qStackNode.Push(q);

            while (pStackNode.Any() && qStackNode.Any())
            {
                if (pStackNode.Peek().left != null && qStackNode.Peek().left != null)
                {
                    pStackNode.Push(pStackNode.Peek().left);
                    qStackNode.Push(qStackNode.Peek().left);

                    if (pStackNode.Peek().val != qStackNode.Peek().val) return false;
                }
                else
                {
                    while (pStackNode.Any() && qStackNode.Any())
                    {
                        var curPNode = pStackNode.Pop();
                        var curQNode = qStackNode.Pop();
                        switch (true)
                        {
                            case true when curPNode.right != null ^ curQNode.right != null:
                            case true when curPNode.left != null ^ curQNode.left != null:
                            case true when curPNode.val != curQNode.val:
                                return false;

                            default:
                                break;
                        }
                        if (curPNode.right != null && curQNode.right != null)
                        {
                            pStackNode.Push(curPNode.right);
                            qStackNode.Push(curQNode.right);
                            break;
                        }
                    }
                }
            }

            return true;
        }
    }
}
