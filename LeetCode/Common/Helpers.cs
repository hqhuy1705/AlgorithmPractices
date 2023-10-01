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
    }
}
