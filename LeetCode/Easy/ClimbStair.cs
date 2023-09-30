namespace AlgorithmPractices.LeetCode
{
    public static class ClimbStair
    {
        /* Requirement
            You are climbing a staircase. It takes n steps to reach the top.
            Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
            Example 1:
                Input: n = 2
                Output: 2
                Explanation: There are two ways to climb to the top.
                1. 1 step + 1 step
                2. 2 steps
            Example 2:
                Input: n = 3
                Output: 3
                Explanation: There are three ways to climb to the top.
                1. 1 step + 1 step + 1 step
                2. 1 step + 2 steps
                3. 2 steps + 1 step
            Constraints:
                1 <= n <= 45
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
        public static List<int> GetTestCases()
        {
            return new List<int>()
            {
                3,
                35,
                10,
                5,
                6,
                7,
                8,
            };
        }

        /// <summary>
        /// Solution2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Solution2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int first = 1;
            int second = 2;
            int output = second;
            for (int i = 3; i <= n; i++)
            {
                output = first + second;
                first = second;
                second = output;
            }
            return output;
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Solution(int n)
        {
            int sum = n;
            int step = n % 2 > 0 ? (n / 2) + 1 : n / 2;
            for (int i = 2; i <= step; i++)
            {
                // i: numbers of '2'
                // numbers of position
                int positions = n - i;
                if (positions > 0)
                {
                    if (i * 2 > n) return sum;
                    var cnk = CnK(positions, i);
                    sum += (int)cnk;
                }

            }
            return sum;
        }

        /// <summary>
        /// CnK
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double CnK(int n, int k)
        {
            double fac1 = Factorial(n);
            double fac2 = Factorial(n - k);
            double fac3 = Factorial(k);
            return (int)((fac1 / fac2 / fac3) + 0.5);
        }

        /// <summary>
        /// Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
