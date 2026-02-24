public class Solution {
    public bool IsBalanced(TreeNode root) {
        return DFS(root) != -1;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        int left = DFS(node.left);
        if (left == -1) return -1;

        int right = DFS(node.right);
        if (right == -1) return -1;

        if (System.Math.Abs(left - right) > 1) return -1;

        return 1 + System.Math.Max(left, right);
    }
}