namespace AlgorithmPractices.LeetCode
{
    public static class TwoSum
    {
        /* Requirement:
                Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
                You may assume that each input would have exactly one solution, and you may not use the same element twice.
                You can return the answer in any order.
            Example 1:
                Input: nums = [2,7,11,15], target = 9
                Output: [0,1]
                Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            Example 2:
                Input: nums = [3,2,4], target = 6
                Output: [1,2]
            Example 3:
                Input: nums = [3,3], target = 6
                Output: [0,1]
            Constraints:
                2 <= nums.length <= 104
                -109 <= nums[i] <= 109
                -109 <= target <= 109
                Only one valid answer exists.
            Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        */

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="nums">List input numbers</param>
        /// <param name="target">Target number</param>
        /// <returns>Indices of the two numbers such that they add up to target.</returns>
        public static int[] Solution(int[] nums, int target)
        {
            int numsSize = nums.Length;
            for (int i = 0; i < numsSize - 1; i++)
            {
                for (int j = i + 1; j < numsSize; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[0];
        }

        /// <summary>
        /// Run solution
        /// </summary>
        public static void RunSolution()
        {
            //Input: nums = [2, 7, 11, 15], target = 9
            //Output: [0, 1]
            var result = Solution(new int[] { 2, 7, 11, 15 }, 9);
            result.Display();

            //Input: nums = [3, 2, 4], target = 6
            //Output: [1,2]
            result = Solution(new int[] { 3, 2, 4 }, 6);
            result.Display();

            //Input: nums = [3, 3], target = 6
            //Output: [0,1]
            result = Solution(new int[] { 3, 3 }, 6);
            result.Display();
        }

        /// <summary>
        /// Display result
        /// </summary>
        /// <param name="list"></param>
        public static void Display(this int[] list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

    }
}
