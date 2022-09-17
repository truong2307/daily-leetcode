namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                    return i;
            }
            return nums.Length;
        }
    }
}
