namespace AlgorithmPractices.LeetCode
{
    public static class MySqrt
    {
        /* Requirement
            Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
            You must not use any built-in exponent function or operator.
            For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
            Example 1:
                Input: x = 4
                Output: 2
                Explanation: The square root of 4 is 2, so we return 2.
            Example 2:
                Input: x = 8
                Output: 2
                Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
            Constraints:
                0 <= x <= 231 - 1
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
        public static List<int> GetTestCases()
        {
            return new List<int>
            {
                25,
                4,
                9,
                16,
                2147483647, // => 46340
            };
        }

        /// <summary>
        /// Solution: Brute-force
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Solution(int number)
        {
            int index = 1;
            while (index * index <= number)
            {
                index++;
                if (index * index >= int.MaxValue || index * index < 0)
                {
                    break;
                }
            }

            return index * index == number ? index : index - 1;
        }

        /// <summary>
        /// Solution2: Binary-search
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Solution2(int number)
        {
            if (number == 0)
                return 0;
            
            int left = 1;
            int right = number;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int sqrt = number / middle;

                if (sqrt == middle)
                    return middle;
                else if (sqrt < middle)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return right;
        }

    }
}
