using System.Collections.Generic;

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new();
        Stack<TreeNode> stack = new();
        TreeNode current = root;

        while (current != null || stack.Count > 0) {
            while (current != null) {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }
        return result;
    }
}