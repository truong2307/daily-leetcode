using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public static class LengthofLastWordLeetCode
    {
        public static int LengthOfLastWord(string s)
        {
            return s.Trim().Split(' ').LastOrDefault().Length;
        }
    }
}
