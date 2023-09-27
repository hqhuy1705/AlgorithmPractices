namespace AlgorithmPractices.LeetCode
{
    public static class PalindromeNumber
    {
        /*
            Given an integer x, return true if x is a palindrome, and false otherwise
            Example 1:
            Input: x = 121
            Output: true
            Explanation: 121 reads as 121 from left to right and from right to left.
            Example 2:
            Input: x = -121
            Output: false
            Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
            Example 3:
            Input: x = 10
            Output: false
            Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var number = 123454321;
            var result = Solution3(123454321);
            Console.WriteLine(number);
            Console.WriteLine(result);

            number = 1234564321;
            result = Solution3(1234564321);
            Console.WriteLine(number);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Compare number in opposite position
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Solution1(int x)
        {
            if (x < 0) return false;

            Dictionary<int, int> map = new Dictionary<int, int>();
            int index = 0;
            while (x > 0)
            {
                map[index] = x % 10;
                x /= 10;
                index++;
            }

            for (int i = 0; i < map.Count / 2; i++)
            {
                var rightIndex = map.Count - i - 1;
                if (map[i] != map[rightIndex]) return false;
            }

            return true;
        }

        /// <summary>
        /// Reversing the Entire Number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Solution2(int x)
        {
            if (x < 0) return false;
            int reversed = 0, temp = x;
            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }
            return reversed == x;
        }

        /// <summary>
        /// Reversing Half of the Number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Solution3(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int reversed = 0;
            int temp = x;

            while (temp > reversed)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            return (temp == reversed) || (temp == reversed / 10);
        }
    }
}
