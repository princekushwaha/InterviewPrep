# 🌳 Binary Tree – DSA Interview Preparation

This folder contains **Binary Tree problems solved for interview preparation**, following a **pattern-based and interview-first approach**.

Each problem includes:
- Problem statement (brief)
- Pattern used
- Brute force idea
- Optimal approach
- Time & Space complexity
- Problem link
- ✅ Link to C# solution file

---

## 🧠 Patterns Covered

- DFS Traversal (Recursive & Iterative)
- Stack Simulation
- BFS (Queue)
- Tree DP (Postorder)
- Global Tracking in Recursion
- Range Validation
- Lowest Common Ancestor Logic

---

# ✅ Problems Solved (Binary Tree)

---

## 1. Inorder Traversal

**Level:** Easy  
**Pattern:** DFS / Stack Simulation  

**Problem:** Return inorder traversal of a binary tree.

**Brute Force:**  
Recursive traversal.

**Optimal Approach:**  
Iterative using stack or recursive.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/binary-tree-inorder-traversal/  
💻 **Code:** [InorderTraversal.cs](./InorderTraversal.cs)

---

## 2. Preorder Traversal

**Level:** Easy  
**Pattern:** DFS  

**Problem:** Return preorder traversal of a binary tree.

**Brute Force:**  
Recursive traversal.

**Optimal Approach:**  
Iterative using stack or recursive.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/binary-tree-preorder-traversal/  
💻 **Code:** [PreorderTraversal.cs](./PreorderTraversal.cs)

---

## 3. Postorder Traversal

**Level:** Medium  
**Pattern:** DFS + lastVisited (Iterative)  

**Problem:** Return postorder traversal.

**Brute Force:**  
Recursive traversal.

**Optimal Approach:**  
One stack + lastVisited pointer.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/binary-tree-postorder-traversal/  
💻 **Code:** [PostorderTraversal.cs](./PostorderTraversal.cs)

---

## 4. Level Order Traversal

**Level:** Medium  
**Pattern:** BFS / Queue  

**Problem:** Return nodes level by level.

**Brute Force:**  
DFS storing levels manually.

**Optimal Approach:**  
Queue-based BFS.

**Time:** O(n)  
**Space:** O(n)

🔗 https://leetcode.com/problems/binary-tree-level-order-traversal/  
💻 **Code:** [LevelOrderTraversal.cs](./LevelOrderTraversal.cs)

---

## 5. Maximum Depth of Binary Tree

**Level:** Easy–Medium  
**Pattern:** Tree Height (Bottom-Up / Top-Down)

**Problem:** Return maximum depth of the tree.

**Brute Force:**  
Compute height repeatedly (inefficient).

**Optimal Approach:**  
Postorder recursion returning height.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/maximum-depth-of-binary-tree/  
💻 **Code:** [MaxDepth.cs](./MaxDepth.cs)

---

## 6. Diameter of Binary Tree

**Level:** Medium  
**Pattern:** Postorder + Global Tracking  

**Problem:** Find longest path between any two nodes.

**Brute Force:**  
Compute height for each node separately (O(n²)).

**Optimal Approach:**  
During height computation, update `leftHeight + rightHeight`.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/diameter-of-binary-tree/  
💻 **Code:** [DiameterOfBinaryTree.cs](./DiameterOfBinaryTree.cs)

---

## 7. Balanced Binary Tree

**Level:** Easy–Medium  
**Pattern:** Postorder + Early Termination  

**Problem:** Check if height difference ≤ 1 at every node.

**Brute Force:**  
Compute height for each node repeatedly.

**Optimal Approach:**  
Return height OR -1 to indicate imbalance.

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/balanced-binary-tree/  
💻 **Code:** [BalancedBinaryTree.cs](./BalancedBinaryTree.cs)

---

## 8. Maximum Path Sum

**Level:** Hard  
**Pattern:** Tree DP + Global Tracking  

**Problem:** Find maximum path sum (path may start & end anywhere).

**Brute Force:**  
Try all paths (exponential).

**Optimal Approach:**  
Postorder:
- Ignore negative gains
- Update `node.val + leftGain + rightGain`
- Return `node.val + max(leftGain, rightGain)`

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/binary-tree-maximum-path-sum/  
💻 **Code:** [MaxPathSum.cs](./MaxPathSum.cs)

---

## 9. Lowest Common Ancestor of Binary Tree

**Level:** Medium  
**Pattern:** Postorder Decision  

**Problem:** Find lowest common ancestor of nodes p and q.

**Brute Force:**  
Store parent paths and compare.

**Optimal Approach:**  
Recursive:
- If both left and right return non-null → current is LCA
- Else propagate non-null child

**Time:** O(n)  
**Space:** O(h)

🔗 https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/  
💻 **Code:** [LowestCommonAncestor.cs](./LowestCommonAncestor.cs)

---

# 📊 Total Binary Tree Problems Solved: 9

---

# 🧠 Coverage Level

You have covered:

✔ All DFS Traversals (Recursive + Iterative)  
✔ BFS Traversal  
✔ Height-based Tree DP  
✔ Diameter Pattern  
✔ Early Termination Pattern  
✔ Global Tracking Pattern  
✔ LCA Logic  
✔ Negative Path Handling  

You now have strong intermediate-level tree mastery.
