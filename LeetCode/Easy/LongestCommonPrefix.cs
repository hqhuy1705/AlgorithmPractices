namespace AlgorithmPractices.LeetCode
{
    public static class LongestCommonPrefix
    {
        /* Requirement
            Write a function to find the longest common prefix string amongst an array of strings.
            If there is no common prefix, return an empty string "".
            Example 1:
                Input: strs = ["flower","flow","flight"]
                Output: "fl"
            Example 2:
                Input: strs = ["dog","racecar","car"]
                Output: ""
                Explanation: There is no common prefix among the input strings.
            Constraints:
                1 <= strs.length <= 200
                0 <= strs[i].length <= 200
                strs[i] consists of only lowercase English letters.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            foreach (var item in GetTestCase())
            {
                var result = Solution1(item);
                Console.WriteLine(string.IsNullOrEmpty(result) ? "#empmty" : result);
            }

            Console.WriteLine("-----------");

            foreach (var item in GetTestCase())
            {
                var result = Solution2(item);
                Console.WriteLine(string.IsNullOrEmpty(result) ? "#empmty" : result);
            }
        }

        /// <summary>
        /// Get Test Case
        /// </summary>
        /// <returns></returns>
        public static List<string[]> GetTestCase()
        {
            return new List<string[]>
            {
                new string[] {"flower", "flow", "flight"}, // => "fl"
                new string[] {"dog", "racecar", "car"}, // => ""
                new string[] {""}, // => ""
                new string[] {"a"}, // => "a"
                new string[] {"flower", "flower", "flower", "flower"}, // => flower
                new string[] {"ab", "a"}, // => "a"
            };
        }

        /// <summary>
        /// Compare first string to the list
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string Solution1(string[] strs)
        {
            if (strs.Length == 1) return strs[0];
            string firstString = strs[0];
            if (firstString.Length == 0) return "";
            string prefix = "";
            for (int index = 0; index < firstString.Length; index++)
            {
                prefix += firstString[index].ToString();

                if (strs.Any(x => !x.StartsWith(prefix)))
                {
                    prefix = prefix.Remove(prefix.Length - 1);
                    break;
                }
            }
            return prefix;
        }

        /// <summary>
        /// Sort list string and compare first with last
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string Solution2(string[] strs)
        {
            string prefix = "";
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length - 1];
            for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
            {
                if (first[i] != last[i])
                {
                    return prefix;
                }
                prefix += first[i];
            }
            return prefix;
        }
    }
}
