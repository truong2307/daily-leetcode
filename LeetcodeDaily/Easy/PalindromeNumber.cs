namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public static class PalindromeNumberLeetCode
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int temp = x;
            int toCompare = 0;
            do
            {
                toCompare = (toCompare * 10) + (temp % 10);
            }
            while ((temp /= 10) > 0);

            return x == toCompare;
        }
    }
}
