namespace AlgorithmPractices.LeetCode
{
    public static class NumIdenticalPair
    {
        /* Requirement
            Given an array of integers nums, return the number of good pairs.
            A pair(i, j) is called good if nums[i] == nums[j] and i<j.

            Example 1:
                Input: nums = [1, 2, 3, 1, 1, 3]
                Output: 4
                Explanation: There are 4 good pairs(0,3), (0,4), (3,4), (2,5) 0-indexed.
            Example 2:
                Input: nums = [1, 1, 1, 1]
                Output: 6
                Explanation: Each pair in the array are good.
            Example 3:
                Input: nums = [1, 2, 3]
                Output: 0
            Constraints:
                1 <= nums.length <= 100
                1 <= nums[i] <= 100
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var testCases = GetTestCases();
            foreach (var testCase in testCases)
            {
                var result = Solution(testCase);
                Console.WriteLine($"{string.Join(", ", testCase)} => {result}");
            }
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<int[]> GetTestCases()
        {
            return new List<int[]>
            {
                new int[] { 1, 2, 3, 1, 1, 3 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 2, 3 },
            };
        }

        /// <summary>
        /// Solution
        /// 2 numbers => 1
        /// 3 numbers => 1 + 2
        /// 4 numbers => 1 + 2 + 3
        /// n numbers => 1 + 2 + 3 + ... + (n-2) + (n-1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Solution(int[] nums)
        {
            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], 1);
                }
                else
                {
                    sum += map[nums[i]]++;
                }
            }
            return sum;
        }
    }
}
