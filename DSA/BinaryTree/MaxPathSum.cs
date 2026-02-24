public class Solution {
    private int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return maxSum;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        int left = System.Math.Max(0, DFS(node.left));
        int right = System.Math.Max(0, DFS(node.right));

        maxSum = System.Math.Max(maxSum, left + right + node.val);

        return node.val + System.Math.Max(left, right);
    }
}