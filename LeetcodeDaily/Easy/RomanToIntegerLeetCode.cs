using System.Collections.Generic;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer
    /// </summary>
    public static class RomanToIntegerLeetCode
    {
        public static int RomanToInt(string s)
        {
            var symbols = new Dictionary<string, int>()
            {
                {"I" , 1},
                {"V", 5},
                {"X" ,10},
                {"L" , 50},
                {"C" , 100},
                {"D" , 500},
                {"M" , 1000},
                {"IV" , 4},
                {"IX" , 9},
                {"XL" , 40},
                {"XC" , 90},
                {"CD" , 400},
                {"CM" , 900},
            };

            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var curNextSymbol = i < s.Length - 1 ? s[i + 1].ToString() : string.Empty;
                var curValue = s[i].ToString();

                if (symbols.ContainsKey(curValue + curNextSymbol))
                {
                    result += symbols[curValue + curNextSymbol];
                    i++;
                }
                else
                {
                    result += symbols[curValue];
                }
            }

            return result;
        }
    }
}
