using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new();
        if (root == null) return result;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int size = queue.Count;
            List<int> level = new();

            for (int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                level.Add(node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(level);
        }
        return result;
    }
}