namespace AlgorithmPractices.LeetCode
{
    public static class DeleteDuplicate
    {
        /* Requirement
            Given the head of a sorted linked list, delete all duplicates such that each element appears only once.Return the linked list sorted as well.
            Example 1:
                Input: head = [1,1,2]
                Output: [1,2]
            Example 2:
                Input: head = [1,1,2,3,3]
                Output: [1,2,3]
            Constraints:
                The number of nodes in the list is in the range[0, 300].
                -100 <= Node.val <= 100
                The list is guaranteed to be sorted in ascending order.
         */

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            var testCases = GetListNodeTest();
            foreach (var testCase in testCases)
            {
                var result = Solution2(testCase);
                result.Display();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode Solution2(ListNode head)
        {
            ListNode prevNode = head;
            for (ListNode node = head.next; node != null; node = node.next)
            {
                if (node.val == prevNode.val)
                {
                    prevNode.next = node.next;
                }
                else
                {
                    prevNode = node;
                }
            }
            return head;
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode Solution(ListNode head)
        {
            HashSet<int> ints = new HashSet<int>();
            ListNode result = new ListNode();
            ListNode temp = result;
            while (head != null)
            {
                if (!ints.Contains(head.val))
                {
                    ints.Add(head.val);
                    result.next = new ListNode(head.val);
                    result = result.next;
                }
                head = head.next;
            }
            return temp.next;
        }

        /// <summary>
        /// Get List Node Test
        /// </summary>
        /// <returns></returns>
        public static List<ListNode> GetListNodeTest()
        {
            List<ListNode> result = new List<ListNode>();
            var testCases = GetTestCases();
            foreach (var testcase in testCases)
            {
                result.Add(ListNodeHelpers.GetNodesFromList(testcase));
            }

            return result;
        }

        /// <summary>
        /// Get Test Cases
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> GetTestCases()
        {
            return new List<List<int>>
            {
                new List<int> {1,1,2,3,4,5,5,5,6,6,6,6,7,7,8},
                new List<int> {1, 1, 2, 3, 3},
            };
        }

    }
}
