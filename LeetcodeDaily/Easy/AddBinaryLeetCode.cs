using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/
    /// </summary>
    public static class AddBinaryLeetCode
    {
        public static string AddBinary(string a, string b)
        {
            string binary1, binary2, binary3;
            var rememberNum = 0;
            var result = new Stack<string>();
            var differnceSubtraction = Math.Abs(a.Length - b.Length);

            if (a.Length > b.Length)
            {
                binary1 = string.Join(string.Empty, a.Skip(differnceSubtraction));
                binary3 = string.Join(string.Empty, a.Take(differnceSubtraction));
                binary2 = b;
            }
            else
            {
                binary1 = string.Join(string.Empty, b.Skip(differnceSubtraction));
                binary3 = string.Join(string.Empty, b.Take(differnceSubtraction));
                binary2 = a;
            }

            for (int i = binary1.Length - 1; i >= 0; i--)
            {
                var curVal1 = int.Parse(binary1[i].ToString());
                var curVal2 = int.Parse(binary2[i].ToString());
                var sumBinary = curVal1 + curVal2 + rememberNum;

                switch (sumBinary)
                {
                    case 0:
                        result.Push("0");
                        rememberNum = 0;
                        break;
                    case 2:
                        result.Push("0");
                        rememberNum = 1;
                        break;

                    case 1:
                        result.Push("1");
                        rememberNum = 0;
                        break;

                    default:
                        result.Push(rememberNum.ToString());
                        rememberNum = 1;
                        break;
                }
            }

            if (rememberNum == 0)
            {
                result.Push(binary3);
            }
            else
            {
                var tempBinary = rememberNum.ToString().PadLeft(binary3.Length, '0');
                result.Push(AddBinary(tempBinary, binary3));
            }

            return string.Join(string.Empty, result);
        }
    }
}
