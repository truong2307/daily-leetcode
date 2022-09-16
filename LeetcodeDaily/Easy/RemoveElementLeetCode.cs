using System.Linq;

namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public static class RemoveElementLeetCode
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var curNumList = nums.ToList();
            foreach (var item in nums)
            {
                if (item == val)
                {
                    curNumList.Remove(item);
                }
            }

            curNumList.ToArray().CopyTo(nums, 0);
            return curNumList.Count;
        }
    }
}
