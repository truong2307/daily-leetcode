
using LeetcodeDaily.Easy;
using LeetcodeDaily.Models;

namespace LeetcodeDaily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //two sum
            var nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            TwoSumLeetCode.TwoSum(nums, 11);

            //Palindrome number
            PalindromeNumberLeetCode.IsPalindrome(0);

            //Roman To Integer
            RomanToIntegerLeetCode.RomanToInt("III");

            //Longest Common Prefix
            LongestCommonPrefixLeetCode.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

            //Valid Parentheses
            ValidParenthesesLeetCode.IsValid("()[]{}");

            //Merge Two Sorted Lists
            var listNode1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var listNode2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            MergeTwoSortedLists.MergeTwoLists(listNode1, listNode2);

            //Remove Duplicates from Sorted Array
            RemoveDuplicatesSortedArray.RemoveDuplicates(new int[] { 1, 1, 2 });

            //Remove Element
            RemoveElementLeetCode.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            //Search Insert Position
            SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);

            //Length of Last Word
            LengthofLastWordLeetCode.LengthOfLastWord("   fly me   to   the moon  ");

            //Plus one
            PlusOneLeetCode.PlusOne(new int[] { 9 });

            //Add Binary
            AddBinaryLeetCode.AddBinary("1010", "1011");

            //Remove Duplicates from Sorted List
            var listNode = new ListNode(1, new ListNode(1, new ListNode(1)));
            RemoveDuplicatesSortedList.DeleteDuplicates(listNode);

            //Merge Sorted Array
            MergeSortedArray.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);

            //Binary Tree Inorder Traversal
            BinaryTreeInorderTraversal.InorderTraversal(new TreeNode(1, left: null, right: new TreeNode(2, left: new TreeNode(3))));

            //Same Tree
            SameTree.IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3)));

            //Symmetric Tree
            var symetricTreeTest = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2,new TreeNode(4), new TreeNode(3)));
            SymmetricTree.IsSymmetric(symetricTreeTest);

            //Maximum Depth of Binary Tree
            MaximumDepthBinaryTree.MaxDepth(new TreeNode(1, new TreeNode(2), new TreeNode(3)));

            //Convert Sorted Array to Binary Search Tree
            SortedArrayToBSTLeetCode.SortedArrayToBST(new int[] { 0,1,2,3,4 });

            //Balanced Binary Tree
            BalancedBinaryTree.IsBalanced(new TreeNode(1, new TreeNode(2), new TreeNode(3)));
        }
    }
}
