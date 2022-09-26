﻿using System.Collections.Generic;

namespace LeetcodeDaily.Easy
{
    public static class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            IList<int> res = new List<int>();
            s.Push(root);
            while (s.Count > 0)
                if (s.Peek().left != null)
                    s.Push(s.Peek().left);
                else
                    while (s.Count > 0)
                    {
                        TreeNode cur = s.Pop();
                        res.Add(cur.val);

                        if (cur.right != null)
                        {
                            s.Push(cur.right);
                            break;
                        }
                    }
            return res;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}

