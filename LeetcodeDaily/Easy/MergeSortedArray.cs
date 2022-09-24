namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int num1Index = m - 1, num2Index = n - 1, mainIndex = m + n - 1;

            while (num1Index > -1 && num2Index > -1)
            {
                if (nums1[num1Index] > nums2[num2Index])
                {
                    nums1[mainIndex] = nums1[num1Index--];
                }
                else
                {
                    nums1[mainIndex] = nums2[num2Index--];
                }
                mainIndex--;
            }

            while (num2Index > -1)
            {
                nums1[mainIndex--] = nums2[num2Index--];
            }
        }
    }
}
