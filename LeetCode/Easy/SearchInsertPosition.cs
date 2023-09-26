namespace AlgorithmPractices.LeetCode
{
    public static class SearchInsertPosition
    {
        /* Requirement
            Given a sorted array of distinct integers and a target value, return the index if the target is found. 
            If not, return the index where it would be if it were inserted in order.
            You must write an algorithm with O(log n) runtime complexity.
            Example 1:
                Input: nums = [1,3,5,6], target = 5
                Output: 2
            Example 2:
                Input: nums = [1,3,5,6], target = 2
                Output: 1
            Example 3:
                Input: nums = [1,3,5,6], target = 7
                Output: 4
            Constraints:
                1 <= nums.length <= 104
                -104 <= nums[i] <= 104
                nums contains distinct values sorted in ascending order.
                -104 <= target <= 104
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var result = Solution3(new int[] { 1, 3, 5, 6 }, 9);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Search Insert Position
        /// </summary>
        /// <param name="nums">Input numbers</param>
        /// <param name="target">Target number</param>
        /// <returns></returns>
        public static int Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target) return i;
            }
            return nums.Length;
        }

        /// <summary>
        /// Search Insert Position
        /// </summary>
        /// <param name="nums">Input numbers</param>
        /// <param name="target">Target number</param>
        /// <returns></returns>
        public static int Solution2(int[] nums, int target)
        {
            if (nums[nums.Length - 1] < target) return nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target) return i;
            }

            return 0;
        }

        /// <summary>
        /// Search Insert Position using binary search, and Bitwise Complement Operator
        ///   For any integer n, the bitwise complement of n will be -(n+1).
        ///     Bitwise complement of N = ~N(represented in 2’s complement form).
        ///     2’complement of ~N= -(~(~N)+1) = -(N+1).
        /// </summary>
        /// <param name="nums">Input numbers</param>
        /// <param name="target">Target number</param>
        /// <returns></returns>
        public static int Solution3(int[] nums, int target)
        {
            var index = Array.BinarySearch(nums, target);
            return index >= 0 ? index : ~index;
        }
    }
}
