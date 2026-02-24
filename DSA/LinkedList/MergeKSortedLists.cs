public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> pq = new();

        foreach (var l in lists)
            if (l != null)
                pq.Enqueue(l, l.val);

        ListNode dummy = new(-1);
        ListNode curr = dummy;

        while (pq.Count > 0)
        {
            var node = pq.Dequeue();
            curr.next = node;
            curr = curr.next;

            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);
        }

        return dummy.next;
    }
}