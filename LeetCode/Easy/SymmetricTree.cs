namespace AlgorithmPractices.LeetCode
{
    public static class SymmetricTree
    {
        /* Requirement
            Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
            Example 1:
                Input: root = [1,2,2,3,4,4,3]
                Output: true
            Example 2:
                Input: root = [1,2,2,null,3,null,3]
                Output: false
            Constraints:
                The number of nodes in the tree is in the range [1, 1000].
                -100 <= Node.val <= 100
            Follow up: Could you solve it both recursively and iteratively?
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var testCases = GetTestCases();
            foreach (var testCase in testCases)
            {
                var tree = testCase.GetTreeNodeFromList(0);
                var result = Solution(tree);
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<List<int?>> GetTestCases()
        {
            return new List<List<int?>>()
            {
                new List<int?>() { 1, 2, 2, 3, 4, 4, 3 },
                new List<int?>() { 1, 2, 2, null, 3, null, 3 },
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool Solution(TreeNode root)
        {
            var left = root.left; var right = root.right;
            return IsSymmetric(left, right);
        }

        /// <summary>
        /// IsSymmetric
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == right) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
