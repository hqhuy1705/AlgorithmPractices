namespace AlgorithmPractices.LeetCode
{
    public static class SingleNumber
    {
        /* Requirement
            Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
            You must implement a solution with a linear runtime complexity and use only constant extra space.
            Example 1:
                Input: nums = [2,2,1]
                Output: 1
            Example 2:
                Input: nums = [4,1,2,1,2]
                Output: 4
            Example 3:
                Input: nums = [1]
                Output: 1
            Constraints:
                1 <= nums.length <= 3 * 104
                -3 * 104 <= nums[i] <= 3 * 104
                Each element in the array appears twice except for one element which appears only once.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var testCases = GetTestCases();
            foreach (var testCase in testCases)
            {
                var result = Solution2(testCase);
                Console.WriteLine($"{string.Join(", ", testCase)} => {result}");
            }
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<int[]> GetTestCases()
        {
            return new List<int[]>()
            {
                new int[] { 2, 2, 1 },
                new int[] { 4, 1, 2, 1, 2 },
                new int[] { 1 }
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <returns></returns>
        public static int Solution(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, num);
                }
                else
                {
                    map.Remove(num);
                }
            }

            return map.Count > 0 ? map.First().Value : 0;
        }

        /// <summary>
        /// Solution 2
        /// </summary>
        /// <returns></returns>
        public static int Solution2(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }

        /// <summary>
        /// Solution 3
        /// </summary>
        /// <returns></returns>
        public static int Solution3(int[] nums)
        {
            return nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).First();
        }

        /// <summary>
        /// Solution 4
        /// </summary>
        /// <returns></returns>
        public static int Solution4(int[] nums)
        {
            return nums.Aggregate((x, i) => x ^ i);
        }
    }
}
