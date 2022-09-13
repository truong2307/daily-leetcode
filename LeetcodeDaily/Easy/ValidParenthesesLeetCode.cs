using System.Collections.Generic;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public static class ValidParenthesesLeetCode
    {
        public static bool IsValid(string s)
        {
            var symbols = new Stack<char>();

            foreach (var item in s)
            {
                switch (item)
                {
                    case '(':
                        symbols.Push(')');
                        break;
                    case '{':
                        symbols.Push('}');
                        break;
                    case '[':
                        symbols.Push(']');
                        break;
                    default:
                        if (symbols.Count == 0 || symbols.Pop() != item) return false;
                        break;
                }
            }

            return symbols.Count == 0;
        }
    }
}
