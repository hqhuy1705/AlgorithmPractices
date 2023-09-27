namespace AlgorithmPractices.LeetCode
{
    public static class PlusOne
    {
        /* Requirement
            You are given a large integer represented as an integer array digits, 
            where each digits[i] is the i(th) digit of the integer. 
            The digits are ordered from most significant to least significant in left-to-right order. 
            The large integer does not contain any leading 0's.
            Increment the large integer by one and return the resulting array of digits.
            Example 1:
                Input: digits = [1,2,3]
                Output: [1,2,4]
                Explanation: The array represents the integer 123.
                Incrementing by one gives 123 + 1 = 124.
                Thus, the result should be [1,2,4].
            Example 2:
                Input: digits = [4,3,2,1]
                Output: [4,3,2,2]
                Explanation: The array represents the integer 4321.
                Incrementing by one gives 4321 + 1 = 4322.
                Thus, the result should be [4,3,2,2].
            Example 3:
                Input: digits = [9]
                Output: [1,0]
                Explanation: The array represents the integer 9.
                Incrementing by one gives 9 + 1 = 10.
                Thus, the result should be [1,0].
            Constraints:
                1 <= digits.length <= 100
                0 <= digits[i] <= 9
                digits does not contain any leading 0's.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var result = Solution2(new int[] { 9, 9, 8, 9 });
            Console.WriteLine(string.Join(", ", result));
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="digits">Input numbers</param>
        /// <returns></returns>
        public static int[] Solution(int[] digits)
        {
            int[] result = new int[digits.Length];
            int temp = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    temp = 1;
                }

                if (temp > 0)
                {
                    int plus = digits[i] + temp;
                    result[i] = plus % 10;
                    temp = plus / 10;
                }
                else
                {
                    result[i] = digits[i];
                }
            }

            if (temp > 0)
            {
                int[] newResult = new int[result.Length + 1];
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    newResult[i + 1] = result[i];
                }
                newResult[0] = temp;
                return newResult;
            }

            return result;
        }

        /// <summary>
        /// Solution2
        /// </summary>
        /// <param name="digits">Input numbers</param>
        /// <returns></returns>
        public static int[] Solution2(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }
    }
}
