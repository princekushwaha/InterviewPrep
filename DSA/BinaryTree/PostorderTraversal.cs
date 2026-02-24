using System.Collections.Generic;

public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new();
        Stack<TreeNode> stack = new();
        TreeNode current = root;
        TreeNode lastVisited = null;

        while (current != null || stack.Count > 0) {
            if (current != null) {
                stack.Push(current);
                current = current.left;
            } else {
                TreeNode peek = stack.Peek();
                if (peek.right != null && lastVisited != peek.right) {
                    current = peek.right;
                } else {
                    result.Add(peek.val);
                    lastVisited = stack.Pop();
                }
            }
        }
        return result;
    }
}