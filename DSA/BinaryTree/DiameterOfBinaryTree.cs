public class Solution {
    private int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return diameter;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        int left = DFS(node.left);
        int right = DFS(node.right);

        diameter = System.Math.Max(diameter, left + right);

        return 1 + System.Math.Max(left, right);
    }
}