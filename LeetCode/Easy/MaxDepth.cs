namespace AlgorithmPractices.LeetCode
{
    public static class MaxDepth
    {
        /* Requirement
            Given the root of a binary tree, return its maximum depth.
            A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
            Example 1:
                Input: root = [3,9,20,null,null,15,7]
                Output: 3
            Example 2:
                Input: root = [1,null,2]
                Output: 2
            Constraints:
                The number of nodes in the tree is in the range [0, 104].
                -100 <= Node.val <= 100
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
                new List<int?>() { 1, 2, 3, 4, 5 },//3
                new List<int?>() { 1, 2, 3 }, // 2
                new List<int?>() { 3, 9, 20, null, null, 15, 7 },//3
                new List<int?>() { 1, null, 2 },//2
            };
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int Solution(TreeNode root)
        {
            return root == null ? 0 : 1 + Math.Max(Solution(root.left), Solution(root.right));
        }
    }
}
