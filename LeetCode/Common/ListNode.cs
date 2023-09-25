namespace AlgorithmPractices.LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void Display()
        {
            Console.Write($"{this.val} ");
            this.next?.Display();
        }
    }
}
