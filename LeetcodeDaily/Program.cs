using LeetcodeDaily.Easy;
using System;

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
        }
    }
}
