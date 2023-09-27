namespace AlgorithmPractices.LeetCode
{
    public static class LengthOfLastWord
    {
        /* Requirement
            Given a string s consisting of words and spaces, return the length of the last word in the string.
            A word is a maximal substring consisting of non-space characters only.
            Example 1:
                Input: s = "Hello World"
                Output: 5
                Explanation: The last word is "World" with length 5.
            Example 2:
                Input: s = "   fly me   to   the moon  "
                Output: 4
                Explanation: The last word is "moon" with length 4.
            Example 3:
                Input: s = "luffy is still joyboy"
                Output: 6
                Explanation: The last word is "joyboy" with length 6.
            Constraints:
                1 <= s.length <= 104
                s consists of only English letters and spaces ' '.
                There will be at least one word in s.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var testCases = GetTestCases();
            foreach(var testCase in testCases)
            {
                var result = Solution(testCase);
                Console.WriteLine($"{testCase} => {result}");
            }
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns></returns>
        public static int Solution(string s)
        {
            return s.Trim().Split(' ').LastOrDefault()?.Length ?? 0;
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTestCases()
        {
            return new List<string>
            {
                "Hello World", // => 5
                "   fly me   to   the moon  ", // => 4
                "luffy is still joyboy", // => 6
            };
        }
    }
}
