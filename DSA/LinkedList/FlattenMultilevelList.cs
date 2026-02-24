public class Solution
{
    public Node Flatten(Node head)
    {
        FlattenDFS(head);
        return head;
    }

    private Node FlattenDFS(Node head)
    {
        Node curr = head;
        Node last = null;

        while (curr != null)
        {
            Node next = curr.next;

            if (curr.child != null)
            {
                Node childTail = FlattenDFS(curr.child);
                curr.next = curr.child;
                curr.child.prev = curr;
                curr.child = null;

                if (next != null)
                {
                    childTail.next = next;
                    next.prev = childTail;
                }

                last = childTail;
            }
            else
            {
                last = curr;
            }

            curr = next;
        }

        return last;
    }
}