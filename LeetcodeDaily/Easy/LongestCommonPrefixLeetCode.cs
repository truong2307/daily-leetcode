using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix
    /// </summary>
    public static class LongestCommonPrefixLeetCode
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var stringToCompare = string.Empty;
            var minLenght = strs.Min(y => y.Length);
            var shorestValue = strs.FirstOrDefault(x => x.Length == minLenght);
            strs = strs.Length < 1 ? strs : strs.Where(c => !c.Equals(shorestValue)).ToArray();
            for (int i = 0; i < minLenght; i++)
            {
                var countSameValue = 0;
                stringToCompare += shorestValue[i].ToString();
                foreach (var item in strs)
                {
                    if (!item[i].ToString().Equals(shorestValue[i].ToString())) break;
                    countSameValue++;
                }

                if (countSameValue != strs.Length) return stringToCompare.Remove(stringToCompare.Length - 1);
            }

            return stringToCompare;
        }
    }
}
