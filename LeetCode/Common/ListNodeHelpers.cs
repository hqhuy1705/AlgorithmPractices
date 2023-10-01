namespace AlgorithmPractices.LeetCode
{
    public static class ListNodeHelpers
    {
        public static ListNode GetNodesFromList(List<int> inputs)
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
