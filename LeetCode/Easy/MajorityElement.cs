namespace AlgorithmPractices.LeetCode
{
    public static class MajorityElement
    {
        /* Requirement
            Given an array nums of size n, return the majority element.
            The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
            Example 1:
                Input: nums = [3,2,3]
                Output: 3
            Example 2:
                Input: nums = [2,2,1,1,1,2,2]
                Output: 2
            Constraints:
                n == nums.length
                1 <= n <= 5 * 104
                -109 <= nums[i] <= 109
            Follow-up: Could you solve the problem in linear time and in O(1) space?
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
            return new List<int[]>()
            {
                new int[] { 1 },
                new int[] { 5 },
                new int[] { 6, 6, 6, 7, 7 },
                new int[] { 3, 2, 3 },
                new int[] { 2, 2, 1, 1, 1, 2, 2 },
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
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }

            return map.FirstOrDefault(a => a.Value > nums.Length / 2).Key;
        }
    }
}
