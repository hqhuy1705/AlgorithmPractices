namespace AlgorithmPractices.LeetCode
{
    public static class PalindromeString
    {
        /* Requirement
            A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
            it reads the same forward and backward. Alphanumeric characters include letters and numbers.
            Given a string s, return true if it is a palindrome, or false otherwise.
            Example 1:
                Input: s = "A man, a plan, a canal: Panama"
                Output: true
                Explanation: "amanaplanacanalpanama" is a palindrome.
            Example 2:
                Input: s = "race a car"
                Output: false
                Explanation: "raceacar" is not a palindrome.
            Example 3:
                Input: s = " "
                Output: true
                Explanation: s is an empty string "" after removing non-alphanumeric characters.
                Since an empty string reads the same forward and backward, it is a palindrome.
            Constraints:
                1 <= s.length <= 2 * 105
                s consists only of printable ASCII characters.
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
                "A man, a plan, a canal: Panama",
                "race a car",
                "",
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Solution(string s)
        {
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            string str = rgx.Replace(s, "").ToLower();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Solution2
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Solution2(string s)
        {
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            string str = rgx.Replace(s, "").ToLower();
            return Reverse(str) == str;
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
