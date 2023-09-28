namespace AlgorithmPractices.LeetCode
{
    public static class LengthOfLongestSubstring
    {
        /* Requirement
            Given a string s, find the length of the longest substring without repeating characters.
            Example 1:
                Input: s = "abcabcbb"
                Output: 3
                Explanation: The answer is "abc", with the length of 3.
            Example 2:
                Input: s = "bbbbb"
                Output: 1
                Explanation: The answer is "b", with the length of 1.
            Example 3:
                Input: s = "pwwkew"
                Output: 3
                Explanation: The answer is "wke", with the length of 3.
                Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
            Constraints:
                0 <= s.length <= 5 * 104
                s consists of English letters, digits, symbols and spaces.
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
                Console.WriteLine($"{testCase} => {result}");
            }
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTestCases()
        {
            return new List<string>
            {
                " ",
                "au",
                "aab",
                "dvdf",
                "bbbbb",
                "pwwkew",
                "abcabcbb",
                "aabaab!bb",
                "aaaaabceddddeeee",
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            string subString = string.Empty;
            int max = 1;

            for (int i = 0; i < s.Length; i++)
            {
                var si = s[i];
                if (subString.Contains(si))
                {
                    subString = subString.Substring(subString.IndexOf(si) + 1);
                }
                subString += si;
                if (subString.Length > max) max = subString.Length;
            }

            return max;
        }
    }
}
