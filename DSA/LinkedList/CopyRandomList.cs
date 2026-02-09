public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        Dictionary<Node, Node> map = new();
        Node curr = head;
        while (curr != null) {
            map[curr] = new Node(curr.val);
            curr = curr.next;
        }
        curr = head;
        while (curr != null) {
            map[curr].next = curr.next != null ? map[curr.next] : null;
            map[curr].random = curr.random != null ? map[curr.random] : null;
            curr = curr.next;
        }
        return map[head];
    }
}