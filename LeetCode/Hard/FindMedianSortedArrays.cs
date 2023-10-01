namespace AlgorithmPractices.LeetCode
{
    public static class FindMedianSortedArrays
    {
        /* Requirement
            Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
            The overall run time complexity should be O(log (m+n)).
            Example 1:
                Input: nums1 = [1,3], nums2 = [2]
                Output: 2.00000
                Explanation: merged array = [1,2,3] and median is 2.
            Example 2:
                Input: nums1 = [1,2], nums2 = [3,4]
                Output: 2.50000
                Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
            Constraints:
                nums1.length == m
                nums2.length == n
                0 <= m <= 1000
                0 <= n <= 1000
                1 <= m + n <= 2000
                -106 <= nums1[i], nums2[i] <= 106
         */

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="nums1">List number 1</param>
        /// <param name="nums2">List number 2</param>
        /// <returns></returns>
        public static double Solution(int[] nums1, int[] nums2)
        {
            var mergedArr = MergeArrayWithSort(nums1 , nums2);
            
            if (mergedArr.Length % 2 == 0)
            {
                return (mergedArr[mergedArr.Length/2] + mergedArr[(mergedArr.Length / 2) - 1]) / 2.0;
            }
            else
            {
                return mergedArr[mergedArr.Length / 2];
            }
        }

        /// <summary>
        /// Merge Array With Sort
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] MergeArrayWithSort(int[] nums1, int[] nums2)
        {
            return nums1.Concat(nums2).OrderBy(x => x).ToArray();
        }

        /// <summary>
        /// RunSolution
        /// </summary>
        public static void RunSolution()
        {
            var result = Solution(new int[] { 1, 2 }, new int[] { 3, 4 });
            Console.WriteLine(result);

            result = Solution(new int[] { 1, 3 }, new int[] { 2 });
            Console.WriteLine(result);
        }
    }
}
