using System.Collections.Generic;

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new();
        if (root == null) return result;

        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0) {
            TreeNode node = stack.Pop();
            result.Add(node.val);

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
        return result;
    }
}