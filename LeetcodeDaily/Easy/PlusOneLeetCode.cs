using System.Collections.Generic;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one
    /// </summary>
    public static class PlusOneLeetCode
    {
        public static int[] PlusOne(int[] digits)
        {
            int plus = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var temp = digits[i] + plus;

                digits[i] = temp % 10;
                plus = temp / 10;
            }

            if (plus == 1)
            {
                var temp = new List<int>() { plus, };
                temp.AddRange(digits);
                return temp.ToArray();
            }

            return digits;
        }
    }
}
