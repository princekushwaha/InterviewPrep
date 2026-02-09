public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode slow = head, fast = head, prev = null;
        while (fast != null && fast.next != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;
        ListNode left = SortList(head);
        ListNode right = SortList(slow);
        return Merge(left, right);
    }

    private ListNode Merge(ListNode l1, ListNode l2) {
        ListNode dummy = new(-1);
        ListNode curr = dummy;
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                curr.next = l1;
                l1 = l1.next;
            } else {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }
        curr.next = l1 ?? l2;
        return dummy.next;
    }
}