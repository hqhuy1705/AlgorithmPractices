﻿namespace AlgorithmPractices.LeetCode
{
    public static class AddTwoNumbers
    {
        /* Requirement
                You are given two non-empty linked lists representing two non-negative integers. 
                The digits are stored in reverse order, and each of their nodes contains a single digit. 
                Add the two numbers and return the sum as a linked list.
                You may assume the two numbers do not contain any leading zero, except the number 0 itself.
            Example 1:
                Input: l1 = [2,4,3], l2 = [5,6,4]
                Output: [7,0,8]
                Explanation: 342 + 465 = 807.
            Example 2:
                Input: l1 = [0], l2 = [0]
                Output: [0]
            Example 3:
                Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
                Output: [8,9,9,9,0,0,0,1]
            Constraints:
                The number of nodes in each linked list is in the range [1, 100].
                0 <= Node.val <= 9
                It is guaranteed that the list represents a number that does not have leading zeros.
         */

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="l1">List number 1</param>
        /// <param name="l2">List number 2</param>
        /// <param name="carry"></param>
        /// <returns>The sum as a linked list.</returns>
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0) // to keep running if we hava a value in l1, l2 or carry
            {
                // two if statments because l1 and l2 can be of different sizes
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10); //digit
                sum /= 10; //carry
                result = result.next;
            }
            return head.next; //we don't want to return head as it will add a node=0 at the start so -> wrong answer
        }

        /// <summary>
        /// Run Solution
        /// </summary>
        public static void RunSolution()
        {
            //Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
            //Output: [7,0,8]
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = Solution(l1, l2);
            result.Display();
            Console.WriteLine();

            //Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
            //Output: [8,9,9,9,0,0,0,1]
            l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            result = Solution(l1, l2);
            result.Display();
        }
    }
}
