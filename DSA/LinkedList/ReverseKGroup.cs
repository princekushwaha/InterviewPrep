public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode curr = head;
        int count = 0;
        while (curr != null && count < k) {
            curr = curr.next;
            count++;
        }
        if (count < k) return head;

        curr = head;
        ListNode prev = null;
        for (int i = 0; i < k; i++) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        head.next = ReverseKGroup(curr, k);
        return prev;
    }
}