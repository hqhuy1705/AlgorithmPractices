namespace AlgorithmPractices.LeetCode
{
    public static class Helpers
    {
        /// <summary>
        /// Display result
        /// </summary>
        /// <param name="list"></param>
        public static void Display(this int[] list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

        /// <summary>
        /// Get ListNode From List int
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static ListNode GetNodesFromList(this List<int> inputs)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            foreach (int item in inputs)
            {
                result.next = new ListNode(item);
                result = result.next;
            }
            return head.next;
        }

        /// <summary>
        /// Get Tree Node From List
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static TreeNode GetTreeNodeFromList(this List<int?> inputs, int index)
        {
            var treeNode = new TreeNode();
            return inputs.GetTreeNodeFromList(treeNode, index);
        }

        /// <summary>
        /// Get Tree Node From List
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="root"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static TreeNode GetTreeNodeFromList(this List<int?> inputs, TreeNode root, int index)
        {
            if (index < inputs.Count && inputs[index] != null)
            {
                root = new TreeNode(inputs[index] ?? 0);
                root.left = inputs.GetTreeNodeFromList(root.left, 2 * index + 1);
                root.right = inputs.GetTreeNodeFromList(root.right, 2 * index + 2);
            }

            return root;
        }
    }
}
