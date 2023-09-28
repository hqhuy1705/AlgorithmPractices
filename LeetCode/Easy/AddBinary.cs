namespace AlgorithmPractices.LeetCode
{
    public static class AddBinary
    {
        /* Requirement
            Given two binary strings a and b, return their sum as a binary string.
            Example 1:
                Input: a = "11", b = "1"
                Output: "100"
            Example 2:
                Input: a = "1010", b = "1011"
                Output: "10101"
            Constraints:
                1 <= a.length, b.length <= 104
                a and b consist only of '0' or '1' characters.
                Each string does not contain leading zeros except for the zero itself.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var result = Solution2("11010", "1011");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Solution(string a, string b)
        {
            if (a.Length > b.Length)
            {
                string fill = new string('0', a.Length - b.Length);
                b = $"{fill}{b}";
            }
            else
            {
                string fill = new string('0', b.Length - a.Length);
                a = $"{fill}{a}";
            }

            char carry = '0';
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                var c = a[i];
                var d = b[i];

                if (c == '1' && d == '1')
                {
                    result = $"{carry}{result}";
                    carry = '1';

                }
                else if (c == '0' && d == '0')
                {
                    result = $"{carry}{result}";
                    carry = '0';
                }
                else
                {
                    result = carry == '1' ? $"0{result}" : $"1{result}";
                }
            }

            if (carry == '1') result = $"1{result}";

            return result;
        }

        /// <summary>
        /// Solution2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Solution2(string a, string b)
        {
            char carry = '0';
            string result = "";
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                var c = i < 0 ? '0' : a[i];
                var d = j < 0 ? '0' : b[j];

                if (c == '1' && d == '1')
                {
                    result = $"{carry}{result}";
                    carry = '1';

                }
                else if (c == '0' && d == '0')
                {
                    result = $"{carry}{result}";
                    carry = '0';
                }
                else
                {
                    result = carry == '1' ? $"0{result}" : $"1{result}";
                }
            }

            if (carry == '1') result = $"1{result}";

            return result;
        }
    }
}
