namespace AlgorithmPractices.LeetCode
{
    public static class SameTree
    {
        /* Requirement
            Given the roots of two binary trees p and q, write a function to check if they are the same or not.
            Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
            Example 1:
                Input: p = [1,2,3], q = [1,2,3]
                Output: true
            Example 2:
                Input: p = [1,2], q = [1,null,2]
                Output: false
            Constraints:

                The number of nodes in both trees is in the range [0, 100].
                -104 <= Node.val <= 104
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var test = GetTestCases();
            foreach (var testCase in test)
            {
                var result2 = Solution(testCase[0], testCase[1]);
                Console.WriteLine(result2);
            }

        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<List<TreeNode>> GetTestCases()
        {
            return new List<List<TreeNode>>()
            {
                new List<TreeNode>{ new TreeNode(1, new TreeNode(2)), new TreeNode(1, null, new TreeNode(2)) },
                new List<TreeNode>{ new TreeNode(1, new TreeNode(2)), new TreeNode(1, new TreeNode(2)) },
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static bool Solution(TreeNode p, TreeNode q)
        {
            if (q != null && p != null)
            {
                if (q.val != p.val) return false;
                return Solution(q.left, p.left) && Solution(q.right, p.right);
            }
            else if (q != null || p != null) return false;
            return true;
        }

        /// <summary>
        /// Solution2
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static bool Solution2(TreeNode p, TreeNode q)
        {
            if (p == q) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return Solution2(p.left, q.left) && Solution2(p.right, q.right);
        }
    }
}
